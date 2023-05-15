using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuntimeVisual.Models
{
    class CompressedTimeModel
    {
        public string AppName { get; set; }
        public TimeSpan AppRunTime { get; set; }

        public CompressedTimeModel(string appName, TimeSpan appRunTime)
        {
            AppName = appName;
            AppRunTime = appRunTime;
        }
    }
}
