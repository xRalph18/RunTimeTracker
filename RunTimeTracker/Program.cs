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
        TimeSaveModel timeData;
        string dataString;
        DateTime startTime = trackedApp.StartTime;

        if (File.Exists(dataPath))
        {
            dataString = File.ReadAllText(dataPath);
            timeData = JsonConvert.DeserializeObject<TimeSaveModel>(dataString);

            trackedApp.WaitForExit();

            DateTime exitTime = DateTime.Now;
            //timeData.Add(new TimeSaveModel(appName, startTime, exitTime));

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