using Newtonsoft.Json;
using RunTimeTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunTimeTracker.Functionality
{
    class Clear
    {
        private static JsonSerializerSettings settings = new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore };

        public static void Cls(string dataPath, string[] command)
        {
            string dataString;

            if (File.Exists(dataPath))
            {
                dataString = File.ReadAllText(dataPath);
                var timeData = JsonConvert.DeserializeObject<List<TimeSaveModel>>(dataString, settings) ?? new List<TimeSaveModel>();

                foreach (var item in timeData.Where(n => n.AppName == command[1]).ToList())
                {
                    timeData.Remove(item);
                }

                dataString = JsonConvert.SerializeObject(timeData);
                File.WriteAllText(dataPath, dataString);

                Console.WriteLine($"Zresetowano {command[1]}");
                Console.ReadKey();
            }
            else
            {
                File.WriteAllText(dataPath, "");
                return;
            }
        }
    }
}
