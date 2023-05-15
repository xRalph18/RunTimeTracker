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
        private static string _compressedTimeDataPath = @"CompressedTime.json";

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
            if (!File.Exists(_compressedTimeDataPath))
            {
                File.WriteAllText(_compressedTimeDataPath, "");
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

            var timeDataInfo = new FileInfo(_timeDataPath);
            float timeDataSize = timeDataInfo.Length / 1_000;

            if (timeDataSize >= 1_000_000)
            {
                FileSize.Text = $"Size: {timeDataSize / 1_000_000:f2} GB";
            }
            else if (timeDataSize >= 1_000)
            {
                FileSize.Text = $"Size: {timeDataSize / 1_000:f2} MB";
            }
            else
            {
                FileSize.Text = $"Size: {timeDataSize:f2} KB";
            }

            Apps.Text = $"Apps: {appRunTime.Count}";
        }

        // Processes & Liked

        private void AddToLiked_Click(object sender, EventArgs e)
        {
            AppTagPanel.Visible = true;
        }

        private void RemoveLiked_Click(object sender, EventArgs e)
        {
            string selectedLikedApp = "";

            if (Liked.SelectedItem != null)
            {
                selectedLikedApp = Liked.SelectedItem.ToString();
            }
            else
            {
                return;
            }

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

            if (Liked.Items.Count > 0)
            {
                Liked.SetSelected(0, true);
            }
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

        // Tracking

        private void StartTracking_Click(object sender, EventArgs e)
        {
            Process trackedApp = new Process();

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
                MessageBox.Show("Process not selected", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ViewAllProcesses.ClearSelected();
            Liked.ClearSelected();

            DateTime startTime = trackedApp.StartTime;
            Tracked.Items.Add(trackedApp.ProcessName);

            this.WindowState = FormWindowState.Minimized;
            trackedApp.WaitForExit();
            this.WindowState = FormWindowState.Normal;

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

        // Check Time Data

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
                    TimeList.Items.Add($"{item.Key} - {CheckMethods.FormatFractions(runTime)}");
                    runTime = new TimeSpan();
                }
            }
        }

        // Clear Time Data

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

        // Save & Import

        private void ImportTime_Click(object sender, EventArgs e)
        {
            File_Time.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
            File_Time.ShowDialog();

            string fileName = File_Time.FileName;
            string fileString = File.ReadAllText(fileName);

            File.WriteAllText(_timeDataPath, fileString);

            var appRunTime = CheckMethods.CheckTime();
            TimeList.Items.Clear();
            foreach (var item in appRunTime)
            {
                TimeList.Items.Add(item);
            }
        }

        private void SaveTime_Click(object sender, EventArgs e)
        {
            Save_Time.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
            Save_Time.ShowDialog();

            string fileName = Save_Time.FileName;
            var timeData = FileMethods.ReadTime();
            string timeString = JsonConvert.SerializeObject(timeData);

            File.WriteAllText(fileName, timeString);
        }

        private void ImportLiked_Click(object sender, EventArgs e)
        {
            File_Liked.Filter = "JSON file (*.json)|*.json|All files (*.*)|*.*";
            File_Liked.ShowDialog();

            string fileName = File_Liked.FileName;
            string fileString = File.ReadAllText(fileName);

            File.WriteAllText(_likedDataPath, fileString);

            var likedData = FileMethods.ReadLiked();
            Liked.Items.Clear();
            foreach (var item in likedData)
            {
                Liked.Items.Add(item.ProcessTag);
            }
        }

        private void SaveLiked_Click(object sender, EventArgs e)
        {
            Save_Liked.Filter = "JSON file (*.json)|*.json|All files (*.*)|*.*";
            Save_Liked.ShowDialog();

            string fileName = Save_Liked.FileName;
            var likedData = FileMethods.ReadLiked();
            string likedString = JsonConvert.SerializeObject(likedData);

            File.WriteAllText(fileName, likedString);
        }

        // Info

        private void ShowInfo_Click(object sender, EventArgs e)
        {
            InfoPanel infoPanel = new InfoPanel();
            infoPanel.ShowDialog();
        }

        private void Compress_Click(object sender, EventArgs e)
        {
            var userConfirmation = MessageBox.Show("This process is EXPERIMENTAL and may lead to errors. You can't revese it and after compression you will no longer be able to check time by date for the compressed part of data.", "Warning: Are you sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (userConfirmation == DialogResult.OK)
            {
                var timeData = FileMethods.ReadTime();
                List<CompressedTimeModel> compressData = new List<CompressedTimeModel>();
                var appGroups = timeData.GroupBy(n => n.AppName);
                TimeSpan runTime = new TimeSpan();

                foreach (var item in appGroups)
                {
                    foreach (var item1 in timeData.Where(n => n.AppName == item.Key))
                    {
                        runTime += item1.ExitTime - item1.StartTime;
                    }
                    compressData.Add(new CompressedTimeModel(item.Key, runTime));
                }

                var compressStrng = JsonConvert.SerializeObject(compressData);
                File.WriteAllText(_compressedTimeDataPath, compressStrng);
                File.WriteAllText(_timeDataPath, "");
            }
            else
            {
                return;
            }
        }
    }
}