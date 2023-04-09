using Newtonsoft.Json;
using RunTimeTracker.Functionality;
using RunTimeTracker.Models;
using System.Diagnostics;

class Program
{
    public static void Main()
    {
        Console.Write("(track) / (check) / (help): ");
        var task = Console.ReadLine().Split(" ");

        string dataPath = "TimeData.json";

        if (task[0] == "track")
        {
            Track.Tracker(dataPath, task);
        }
        else if (task[0] == "check")
        {
            Check.Checker(dataPath, task);
        }
        else if (task[0] == "list")
        {
            AppList.List(task);
        }
        else if (task[0] == "cls" || task[0] == "clear")
        {
            Clear.Cls(dataPath, task);
        }
        else if (task[0] == "help")
        {
            Commands.Help(task);
        }
        else
        {
            return;
        }
    }
}