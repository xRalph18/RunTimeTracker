using Newtonsoft.Json;
using RunTimeTracker.Models;

namespace RunTimeTracker.Functionality
{
    class Check
    {
        private static JsonSerializerSettings settings = new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore };

        public static void Checker(string dataPath, string[] command)
        {
            string dataString;

            if (File.Exists(dataPath))
            {
                dataString = File.ReadAllText(dataPath);
                var timeData = JsonConvert.DeserializeObject<List<TimeSaveModel>>(dataString, settings) ?? new List<TimeSaveModel>();
                TimeSpan runTime = new TimeSpan();

                if (command.Length == 2)
                {
                    foreach (var item in timeData.Where(n => n.AppName == command[1]))
                    {
                        runTime += item.ExitTime - item.StartTime;
                    }

                    Console.WriteLine(runTime);
                    Console.ReadKey();
                }
                else if (command.Length == 3)
                {
                    foreach (var item in timeData.Where(n => n.AppName == command[1] && n.StartTime.Date == DateTime.Parse(command[2])))
                    {
                        runTime += item.ExitTime - item.StartTime;
                    }

                    Console.WriteLine(runTime);
                    Console.ReadKey();
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
