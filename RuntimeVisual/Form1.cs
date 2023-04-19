using System.Diagnostics;

namespace RuntimeVisual
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var processes = Process.GetProcesses().DistinctBy(n => n.ProcessName);

            foreach (var item in processes)
            {
                ViewAllProcesses.Items.Add(item.ProcessName);
            }

            string dataStoragePath = @"StorageData\Liked.json";

            if (File.Exists(dataStoragePath))
            {
                File.ReadAllText(dataStoragePath);
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

        }
    }
}