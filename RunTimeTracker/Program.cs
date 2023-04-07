using Newtonsoft.Json;
using RunTimeTracker.Models;
using System.Diagnostics;

class Program
{
    public static void Main()
    {
        Console.Write("(track) / (check) / (list): ");
        var task = Console.ReadLine();

        string dataPath = "TimeData.json";
        string dataString;

        var settings = new JsonSerializerSettings
        {
            NullValueHandling = NullValueHandling.Ignore,
        };

        if (task == "track")
        {
            Console.Write("Podaj nazwę aplikacji, którą chcesz ślidzić: ");
            string appName = Console.ReadLine();

            var trackedApp = Process.GetProcessesByName(appName).FirstOrDefault();
            DateTime startTime = trackedApp.StartTime;

            if (File.Exists(dataPath))
            {
                dataString = File.ReadAllText(dataPath);
                var timeData = JsonConvert.DeserializeObject<List<TimeSaveModel>>(dataString, settings) ?? new List<TimeSaveModel>();

                trackedApp.WaitForExit();

                DateTime exitTime = DateTime.Now;
                timeData.Add(new TimeSaveModel(appName, startTime, exitTime));

                dataString = JsonConvert.SerializeObject(timeData);
                File.WriteAllText(dataPath, dataString);
            }
            else
            {
                File.WriteAllText(dataPath, "");
                return;
            }
        }
        else if (task == "check")
        {
            Console.Write("Podaj nazwę aplikacji, której czas chcesz sprawdzić: ");
            var appToCheck = Console.ReadLine();

            if (File.Exists(dataPath))
            {
                dataString = File.ReadAllText(dataPath);
                var timeData = JsonConvert.DeserializeObject<List<TimeSaveModel>>(dataString, settings) ?? new List<TimeSaveModel>();
                TimeSpan runTime = new TimeSpan();

                foreach (var item in timeData.Where(n => n.AppName == appToCheck))
                {
                    runTime += item.ExitTime - item.StartTime;
                }

                Console.WriteLine(runTime);
                Console.ReadKey();
            }
            else
            {
                File.WriteAllText(dataPath, "");
                return;
            }
        }
        else if (task == "list")
        {
            var processesString = File.ReadAllText("ProcessesNames.json");
            var processesList = JsonConvert.DeserializeObject<List<ProcessesNamesModel>>(processesString, settings);

            foreach (var item in processesList)
            {
                Console.WriteLine($"{item.AppName}: {item.AppProcessName}");
            }
        }
        else
        {
            return;
        }
    }
}