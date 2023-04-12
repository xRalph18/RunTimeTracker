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

        public static void Tracker(string dataPath, string command)
        {
            var commandList = command.Split(" ", 2);
            string dataString;

            var trackedApp = Process.GetProcessesByName(commandList[1]).FirstOrDefault();
            DateTime startTime = trackedApp.StartTime;

            trackedApp.WaitForExit();

            if (File.Exists(dataPath))
            {
                if (commandList.Length == 2)
                {
                    dataString = File.ReadAllText(dataPath);
                    var timeData = JsonConvert.DeserializeObject<List<TimeSaveModel>>(dataString, settings) ?? new List<TimeSaveModel>();

                    DateTime exitTime = DateTime.Now;
                    timeData.Add(new TimeSaveModel(commandList[1], startTime, exitTime));

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
