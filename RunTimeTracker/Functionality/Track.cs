using Newtonsoft.Json;
using RunTimeTracker.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunTimeTracker.Functionality
{
    class Track
    {
        private static JsonSerializerSettings settings = new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore };

        public static void Tracker(string dataPath, string[] command)
        {
            string dataString;

            var trackedApp = Process.GetProcessesByName(command[1]).FirstOrDefault();
            DateTime startTime = trackedApp.StartTime;

            if (File.Exists(dataPath))
            {
                if (command.Length == 2)
                {
                    dataString = File.ReadAllText(dataPath);
                    var timeData = JsonConvert.DeserializeObject<List<TimeSaveModel>>(dataString, settings) ?? new List<TimeSaveModel>();

                    trackedApp.WaitForExit();

                    DateTime exitTime = DateTime.Now;
                    timeData.Add(new TimeSaveModel(command[1], startTime, exitTime));

                    dataString = JsonConvert.SerializeObject(timeData);
                    File.WriteAllText(dataPath, dataString);
                }
                else
                {
                    Console.WriteLine("Niepoprawna ilość parametrów");
                    Console.ReadKey();
                }
            }
            else
            {
                File.WriteAllText(dataPath, "");
                return;
            }
        }
    }
}
