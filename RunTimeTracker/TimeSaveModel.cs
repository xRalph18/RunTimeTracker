using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunTimeTracker
{
    class TimeSaveModel
    {
        public string AppName { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime ExitTime { get; set; }

        public TimeSaveModel(string appName, DateTime startTime, DateTime exitTime)
        {
            AppName = appName;
            StartTime = startTime;
            ExitTime = exitTime;
        }
    }
}
