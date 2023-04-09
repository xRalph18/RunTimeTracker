using Newtonsoft.Json;
using RunTimeTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunTimeTracker.Functionality
{
    class Commands
    {
        private static JsonSerializerSettings settings = new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore };

        public static void Help(string[] task)
        {
            var helpString = File.ReadAllText("Help.json");
            var helpList = JsonConvert.DeserializeObject<List<HelpModel>>(helpString, settings);

            if (task.Length == 1)
            {
                foreach (var item in helpList)
                {
                    Console.Write($"{item.Name}, ");
                }

                Console.ReadKey();
            }
            else if (task.Length == 2)
            {
                if (task[1] == "track")
                {
                    foreach (var item in helpList.Where(n => n.Name == "track"))
                    {
                        Console.WriteLine($"{item.Name} > {item.Command} \n");
                        Console.WriteLine($"{item.Description}");
                    }

                    Console.ReadKey();
                }
                else if (task[1] == "check")
                {
                    foreach (var item in helpList.Where(n => n.Name == "check"))
                    {
                        Console.WriteLine($"{item.Name} > {item.Command} \n");
                        Console.WriteLine($"{item.Description}");
                    }

                    Console.ReadKey();
                }
                else if (task[1] == "list")
                {
                    foreach (var item in helpList.Where(n => n.Name == "list"))
                    {
                        Console.WriteLine($"{item.Name} > {item.Command} \n");
                        Console.WriteLine($"{item.Description}");
                    }

                    Console.ReadKey();
                }
                else if (task[1] == "clear" || task[0] == "cls")
                {
                    foreach (var item in helpList.Where(n => n.Name == "clear"))
                    {
                        Console.WriteLine($"{item.Name} > {item.Command} \n");
                        Console.WriteLine($"{item.Description}");
                    }

                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("Niepoprawna ilość parametrów");
                Console.ReadKey();
            }
        }
    }
}
