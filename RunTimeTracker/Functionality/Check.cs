using Newtonsoft.Json;
using RunTimeTracker.Models;

namespace RunTimeTracker.Functionality
{
    class Check
    {
        private static JsonSerializerSettings settings = new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore };

        public static void Checker(string dataPath, string command)
        {
            var commandList = command.Split(" ");
            string dataString;

            if (File.Exists(dataPath))
            {
                dataString = File.ReadAllText(dataPath);
                var timeData = JsonConvert.DeserializeObject<List<TimeSaveModel>>(dataString, settings) ?? new List<TimeSaveModel>();
                TimeSpan runTime = new TimeSpan();

                if (command.Contains("-t"))
                {
                    if (command.Contains("-s"))
                    {
                        commandList[1] = commandList[1] + " " + commandList[2];

                        foreach (var item in timeData.Where(n => n.AppName == commandList[1] && n.StartTime.Date == DateTime.Parse(commandList[3])))
                        {
                            runTime += item.ExitTime - item.StartTime;
                        }
                    }
                    else
                    {
                        foreach (var item in timeData.Where(n => n.AppName == commandList[1] && n.StartTime.Date == DateTime.Parse(commandList[2])))
                        {
                            runTime += item.ExitTime - item.StartTime;
                        }
                    }

                    Console.WriteLine(runTime);
                    Console.ReadKey();
                }
                else if (!command.Contains("-t"))
                {
                    if (command.Contains("-s"))
                    {
                        commandList[1] = commandList[1] + " " + commandList[2];
                    }

                    foreach (var item in timeData.Where(n => n.AppName == commandList[1]))
                    {
                        runTime += item.ExitTime - item.StartTime;
                    }

                    Console.WriteLine(runTime);
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Coś poszło nie tak");
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
