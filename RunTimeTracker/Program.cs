using Newtonsoft.Json;
using RunTimeTracker;
using System.Diagnostics;
using System.Text.Json.Serialization;

class Program
{
    public static void Main()
    {
        Console.Write("Podaj nazwę aplikacji, którą chcesz ślidzić: ");
        string appName = Console.ReadLine();
        string dataPath = "TimeData.json";
        List<TimeSaveModel> timeData;
        string dataString;

        if (File.Exists(dataPath))
        {
            dataString = File.ReadAllText(dataPath);
            timeData = JsonConvert.DeserializeObject<List<TimeSaveModel>>(dataString);
        }
        else
        {
            File.WriteAllText(dataPath, "");
        }

        var trackedApp = Process.GetProcessesByName(appName).FirstOrDefault();
    }
}