using Newtonsoft.Json;
using RunTimeTracker.Models;
using RuntimeVisual.Methods;
using RuntimeVisual.Models;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RuntimeVisual
{
    public partial class Form1 : Form
    {
        private static JsonSerializerSettings _settings = new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore };
        private static string _timeDataPath = @"TimeData.json";
        private static string _likedDataPath = @"Liked.json";

        public Form1()
        {
            InitializeComponent();

            // Create files
            if (!File.Exists(_likedDataPath))
            {
                File.WriteAllText(_likedDataPath, "");
            }
            if (!File.Exists(_timeDataPath))
            {
                File.WriteAllText(_timeDataPath, "");
            }

            var likedData = FileMethods.ReadLiked();
            var processes = Process.GetProcesses().DistinctBy(n => n.ProcessName).Where(n => !likedData.Any(n2 => n2.ProcessName == n.ProcessName));
            var appRunTime = CheckMethods.CheckTime();

            // Fill processes list
            foreach (var item in processes)
            {
                ViewAllProcesses.Items.Add(item.ProcessName);
            }

            // Fill liked list
            foreach (var item in likedData)
            {
                Liked.Items.Add(item.ProcessTag);
            }

            // Fill time list
            foreach (var item in appRunTime)
            {
                TimeList.Items.Add(item);
            }
        }

        private void AddToLiked_Click(object sender, EventArgs e)
        {
            AppTagPanel.Visible = true;
        }

        private void RemoveLiked_Click(object sender, EventArgs e)
        {
            string selectedLikedApp = Liked.SelectedItem.ToString();

            var likedData = FileMethods.ReadLiked();

            foreach (var item in likedData.Where(n => n.ProcessTag == selectedLikedApp).ToList())
            {
                likedData.Remove(item);
            }

            Liked.Items.Clear();
            foreach (var item in likedData)
            {
                Liked.Items.Add(item.ProcessTag);
            }

            var processes = Process.GetProcesses().DistinctBy(n => n.ProcessName).Where(n => !likedData.Any(n2 => n2.ProcessName == n.ProcessName));
            ViewAllProcesses.Items.Clear();
            foreach (var item in processes)
            {
                ViewAllProcesses.Items.Add(item.ProcessName);
            }


            string likedDataString = JsonConvert.SerializeObject(likedData);
            File.WriteAllText(_likedDataPath, likedDataString);
            Liked.ClearSelected();
        }

        private void SubmitTag_Click(object sender, EventArgs e)
        {
            AppTagPanel.Visible = false;

            string tag = AppTag.Text;
            string selectedApp = ViewAllProcesses.SelectedItem.ToString();

            var likedData = FileMethods.ReadLiked();

            likedData.Add(new LikedModel(selectedApp, tag));
            string likedDataString = JsonConvert.SerializeObject(likedData);

            Liked.Items.Clear();
            foreach (var item in likedData)
            {
                Liked.Items.Add(item.ProcessTag);
            }

            File.WriteAllText(_likedDataPath, likedDataString);
            AppTag.Text = "";
            ViewAllProcesses.ClearSelected();
        }

        private void CancleTag_Click(object sender, EventArgs e)
        {
            AppTag.Text = "";
            ViewAllProcesses.ClearSelected();
            AppTagPanel.Visible = false;
        }

        private void RefreshProcesses_Click(object sender, EventArgs e)
        {
            var processes = Process.GetProcesses().DistinctBy(n => n.ProcessName);
            var likedData = FileMethods.ReadLiked();

            ViewAllProcesses.Items.Clear();
            foreach (var item in processes)
            {
                ViewAllProcesses.Items.Add(item.ProcessName);
            }

            Liked.Items.Clear();
            foreach (var item in likedData)
            {
                Liked.Items.Add(item.ProcessTag);
            }
        }

        private void StartTracking_Click(object sender, EventArgs e)
        {
            Process trackedApp = Process.GetCurrentProcess();

            if (ViewAllProcesses.SelectedItem != null)
            {
                trackedApp = Process.GetProcessesByName(ViewAllProcesses.SelectedItem.ToString()).FirstOrDefault();
            }
            else if (Liked.SelectedItem != null)
            {
                string selectedApp = Liked.SelectedItem.ToString();
                var likedData = FileMethods.ReadLiked();

                trackedApp = Process.GetProcessesByName(likedData.Where(n => n.ProcessTag == selectedApp).Select(n => n.ProcessName).FirstOrDefault()).FirstOrDefault();
            }
            else
            {
                MessageBox.Show("Process not selected");
                return;
            }

            ViewAllProcesses.ClearSelected();
            Liked.ClearSelected();

            DateTime startTime = trackedApp.StartTime;
            Tracked.Items.Add(trackedApp.ProcessName);

            trackedApp.WaitForExit();

            Tracked.Items.Clear();

            var timeData = FileMethods.ReadTime();

            DateTime exitTime = DateTime.Now;
            timeData.Add(new TimeSaveModel(trackedApp.ProcessName, startTime, exitTime));

            string timeDataString = JsonConvert.SerializeObject(timeData);
            File.WriteAllText(_timeDataPath, timeDataString);

            var appRunTime = CheckMethods.CheckTime();
            TimeList.Items.Clear();
            foreach (var item in appRunTime)
            {
                TimeList.Items.Add(item);
            }
        }

        private void CheckTime_Click(object sender, EventArgs e)
        {
            var appRunTime = CheckMethods.CheckTime();

            TimeList.Items.Clear();
            foreach (var item in appRunTime)
            {
                TimeList.Items.Add(item);
            }
        }

        private void CheckByDate_ValueChanged(object sender, EventArgs e)
        {
            var timeData = FileMethods.ReadTime();

            TimeSpan runTime = new TimeSpan();
            var appGroups = timeData.GroupBy(n => n.AppName);

            TimeList.Items.Clear();
            foreach (var item in appGroups)
            {
                foreach (var item2 in timeData.Where(n => n.AppName == item.Key && n.StartTime.Date == CheckByDate.Value.Date))
                {
                    runTime += item2.ExitTime - item2.StartTime;
                }

                if (runTime != new TimeSpan())
                {
                    TimeList.Items.Add($"{item.Key} - {runTime}");
                    runTime = new TimeSpan();
                }
            }
        }

        private void ClearSelectedBttn_Click(object sender, EventArgs e)
        {
            string selectedTime = TimeList.SelectedItem.ToString();

            var timeData = FileMethods.ReadTime();

            foreach (var item in timeData.Where(n => selectedTime.Contains(n.AppName)).ToList())
            {
                timeData.Remove(item);
            }

            string timeDataString = JsonConvert.SerializeObject(timeData);
            File.WriteAllText(_timeDataPath, timeDataString);
            TimeList.ClearSelected();

            var appRunTime = CheckMethods.CheckTime();
            TimeList.Items.Clear();
            foreach (var item in appRunTime)
            {
                TimeList.Items.Add(item);
            }
        }

        private void ClearAllBttn_Click(object sender, EventArgs e)
        {
            var userConfirmation = MessageBox.Show("Do you want to delete all of time data?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (userConfirmation == DialogResult.Yes)
            {
                File.WriteAllText(_timeDataPath, "");
                TimeList.Items.Clear();
            }
        }
    }
}