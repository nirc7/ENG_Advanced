using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimedQueueProj
{
    class TimedOutException : Exception
    {
        public TimedOutException(string m): base(m){}
    }
}
