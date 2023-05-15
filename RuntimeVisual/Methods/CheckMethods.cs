using Newtonsoft.Json;
using RunTimeTracker.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace RuntimeVisual.Methods
{
    class CheckMethods
    {
        public static TimeSpan FormatFractions(TimeSpan timeSpan)
        {
            return new TimeSpan(timeSpan.Days, timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds); 
        }

        public static List<string> CheckTime()
        {
            var timeList = new List<string>();
            var timeData = FileMethods.ReadTime();
            var compressedTimeData = FileMethods.ReadCompressedTime();

            TimeSpan runTime = new TimeSpan();
            var appGroups = timeData.GroupBy(n => n.AppName);

            foreach (var item in appGroups)
            {
                foreach (var item2 in timeData.Where(n => n.AppName == item.Key))
                {
                    runTime += item2.ExitTime - item2.StartTime;
                }

                foreach (var item3 in compressedTimeData.Where(n => n.AppName == item.Key))
                {
                    runTime += item3.AppRunTime;
                }

                timeList.Add($"{item.Key} - {FormatFractions(runTime)}");
                runTime = new TimeSpan();
            }

            return timeList;
        }
    }
}
