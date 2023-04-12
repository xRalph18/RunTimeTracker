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
    class AppList
    {
        private static JsonSerializerSettings settings = new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore };

        public static void List(string command)
        {
            var commandList = command.Split(" ", 2);
            var processesString = File.ReadAllText("ProcessesNames.json");
            var processesList = JsonConvert.DeserializeObject<List<ProcessesNamesModel>>(processesString, settings);

            if (commandList.Length == 1)
            {
                foreach (var item in processesList)
                {
                    Console.WriteLine($"{item.AppName}: {item.AppProcessName}");
                }
            }
            else if (commandList.Length == 2)
            {
                var processes = Process.GetProcesses();;

                foreach (var item in processes)
                {
                    Console.WriteLine(item.ProcessName);
                }
            }

            Console.ReadKey();
        }
    }
}
