using Newtonsoft.Json;
using RunTimeTracker.Functionality;
using RunTimeTracker.Models;
using System.Diagnostics;

class Program
{
    public static void Main()
    {
        Console.Write("(track) / (check) / (help): ");
        var task = Console.ReadLine();
        var taskSplit = task.Split(" ");

        string dataPath = "TimeData.json";

        if (taskSplit[0] == "track")
        {
            Track.Tracker(dataPath, task);
        }
        else if (taskSplit[0] == "check")
        {
            Check.Checker(dataPath, task);
        }
        else if (taskSplit[0] == "list")
        {
            AppList.List(task);
        }
        else if (taskSplit[0] == "cls" || taskSplit[0] == "clear")
        {
            Clear.Cls(dataPath, task);
        }
        else if (taskSplit[0] == "help")
        {
            Commands.Help(taskSplit);
        }
        else
        {
            return;
        }
    }
}