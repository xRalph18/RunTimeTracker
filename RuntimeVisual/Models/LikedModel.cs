using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuntimeVisual.Models
{
    class LikedModel
    {
        public string ProcessName { get; set; }
        public string ProcessTag { get; set; }

        public LikedModel(string processname, string processtag)
        {
            ProcessName = processname;
            ProcessTag = processtag;
        }
    }
}
