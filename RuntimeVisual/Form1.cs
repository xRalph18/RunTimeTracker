using Newtonsoft.Json;
using RunTimeTracker.Models;
using RuntimeVisual.Models;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RuntimeVisual
{
    public partial class Form1 : Form
    {
        private static JsonSerializerSettings settings = new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore };

        public Form1()
        {
            InitializeComponent();

            var processes = Process.GetProcesses().DistinctBy(n => n.ProcessName);

            foreach (var item in processes)
            {
                ViewAllProcesses.Items.Add(item.ProcessName);
            }

            string dataStoragePath = @"Liked.json";

            if (File.Exists(dataStoragePath))
            {
                string storageDataString = File.ReadAllText(dataStoragePath);
                var storageData = JsonConvert.DeserializeObject<List<LikedModel>>(storageDataString, settings) ?? new List<LikedModel>();

                foreach (var item in storageData)
                {
                    Liked.Items.Add(item.ProcessTag);
                }
            }
            else
            {
                File.WriteAllText(dataStoragePath, "");
            }
        }

        private void ViewProcesses_SelectedIndexChanged(object sender, EventArgs e)
        {
            test.Text = ViewAllProcesses.SelectedItem as string;
        }

        private void AddToLiked_Click(object sender, EventArgs e)
        {
            AppTagPanel.Visible = true;
        }

        private void RemoveLiked_Click(object sender, EventArgs e)
        {
            string selectedLikedApp = Liked.SelectedItem.ToString();

            string likedDataPath = @"Liked.json";

            if (File.Exists(likedDataPath))
            {
                string likedDataString = File.ReadAllText(likedDataPath);
                var likedData = JsonConvert.DeserializeObject<List<LikedModel>>(likedDataString, settings) ?? new List<LikedModel>();

                foreach (var item in likedData.Where(n => n.ProcessTag == selectedLikedApp).ToList())
                {
                    likedData.Remove(item);
                }

                Liked.Items.Clear();
                foreach (var item in likedData)
                {
                    Liked.Items.Add(item.ProcessTag);
                }

                likedDataString = JsonConvert.SerializeObject(likedData);
                File.WriteAllText(likedDataPath, likedDataString);
                Liked.ClearSelected();
            }
            else
            {
                File.WriteAllText(likedDataPath, "");
            }
        }

        private void SubmitTag_Click(object sender, EventArgs e)
        {
            AppTagPanel.Visible = false;

            string tag = AppTag.Text;
            string selectedApp = ViewAllProcesses.SelectedItem.ToString();

            string likedDataPath = @"Liked.json";

            if (File.Exists(likedDataPath))
            {
                string likedDataString = File.ReadAllText(likedDataPath);
                var likedData = JsonConvert.DeserializeObject<List<LikedModel>>(likedDataString, settings) ?? new List<LikedModel>();

                likedData.Add(new LikedModel(selectedApp, tag));
                likedDataString = JsonConvert.SerializeObject(likedData);

                Liked.Items.Clear();
                foreach (var item in likedData)
                {
                    Liked.Items.Add(item.ProcessTag);
                }

                File.WriteAllText(likedDataPath, likedDataString);
                AppTag.Text = "";
                ViewAllProcesses.ClearSelected();
            }
            else
            {
                File.WriteAllText(likedDataPath, "");
            }
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
            string likedDataPath = @"Liked.json";


            ViewAllProcesses.Items.Clear();
            foreach (var item in processes)
            {
                ViewAllProcesses.Items.Add(item.ProcessName);
            }

            if (File.Exists(likedDataPath))
            {
                string likedDataString = File.ReadAllText(likedDataPath);
                var likedData = JsonConvert.DeserializeObject<List<LikedModel>>(likedDataString, settings) ?? new List<LikedModel>();

                Liked.Items.Clear();
                foreach (var item in likedData)
                {
                    Liked.Items.Add(item.ProcessTag);
                }
            }
            else
            {
                File.WriteAllText(likedDataPath, "");
            }
        }

        private void StartTracking_Click(object sender, EventArgs e)
        {
            string timeDataPath = @"TimeData.json";
            string likedDataPath = @"Liked.json";
            Process trackedApp = Process.GetCurrentProcess();

            if (ViewAllProcesses.SelectedItem != null)
            {
                trackedApp = Process.GetProcessesByName(ViewAllProcesses.SelectedItem.ToString()).FirstOrDefault();
            }
            else if (Liked.SelectedItem != null)
            {
                string selectedApp = Liked.SelectedItem.ToString();
                string likedDataString = File.ReadAllText(likedDataPath);
                var likedData = JsonConvert.DeserializeObject<List<LikedModel>>(likedDataString, settings) ?? new List<LikedModel>();

                trackedApp = Process.GetProcessesByName(likedData.Where(n => n.ProcessTag == selectedApp).Select(n => n.ProcessName).FirstOrDefault()).FirstOrDefault();
            }
            else
            {
                MessageBox.Show("Process not selected");
            }

            DateTime startTime = trackedApp.StartTime;

            trackedApp.WaitForExit();

            if (File.Exists(timeDataPath))
            {
                string timeDataString = File.ReadAllText(timeDataPath);
                var timeData = JsonConvert.DeserializeObject<List<TimeSaveModel>>(timeDataString, settings) ?? new List<TimeSaveModel>();

                DateTime exitTime = DateTime.Now;
                timeData.Add(new TimeSaveModel(trackedApp.ProcessName, startTime, exitTime));

                timeDataString = JsonConvert.SerializeObject(timeData);
                File.WriteAllText(timeDataPath, timeDataString);
            }
            else
            {
                File.WriteAllText(timeDataPath, "");
            }
        }
    }
}