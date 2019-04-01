using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimedQueueProj
{
    class Athlte
    {
        public int AthleteID { get; set; }
        public string AthleteName { get; set; }

        public override string ToString()
        {
            return $"{AthleteID} *** {AthleteName}";
        }
    }
}
