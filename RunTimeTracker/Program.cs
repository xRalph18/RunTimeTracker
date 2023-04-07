using Newtonsoft.Json;
using RunTimeTracker;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

class Program
{
    public static void Main()
    {
        Console.Write("Podaj nazwę aplikacji, którą chcesz ślidzić: ");
        string appName = Console.ReadLine();

        var trackedApp = Process.GetProcessesByName(appName).FirstOrDefault();
        string dataPath = "TimeData.json";
        string dataString;
        DateTime startTime = trackedApp.StartTime;

        var settings = new JsonSerializerSettings
        {
            NullValueHandling = NullValueHandling.Ignore,
        };

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
}