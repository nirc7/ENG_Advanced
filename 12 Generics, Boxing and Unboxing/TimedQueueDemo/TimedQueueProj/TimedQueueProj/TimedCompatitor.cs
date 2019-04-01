using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimedQueueProj
{
    class TimedCompatitor<T>
    {
        public T MyCompatitor { get; set; }
        public DateTime ArrivalTime { get; set; }

        public TimedCompatitor()
        {
            ArrivalTime = DateTime.Now;
        }

        public override string ToString()
        {
            return MyCompatitor.ToString() + " -- " + ArrivalTime;
        }
    }
}
