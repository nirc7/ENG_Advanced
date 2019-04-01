using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimedQueueProj
{
    class TimedQueue<T> : Queue<TimedCompatitor<T>>
    {
        DateTime FirstArrival;
        DateTime FirstDeparture;

        public void Enqueue(T t)
        {
            TimedCompatitor<T> tc = new TimedCompatitor<T>() { MyCompatitor = t };
            if (Count == 0)
                FirstArrival = tc.ArrivalTime;            

            Enqueue(tc);
        }

        public new T Dequeue()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("Timed Qeueue is Empty!!!");
                //return Dequeue();
            }
            else
            {
                //the first that arrived leaves now
                if (Peek().ArrivalTime == FirstArrival)
                {
                    FirstDeparture = DateTime.Now;
                    return base.Dequeue().MyCompatitor;
                }
                else
                {
                    TimeSpan delta =  Peek().ArrivalTime.Subtract(FirstArrival); 
                    if (  DateTime.Now.Subtract(FirstDeparture) >= delta)
                    {
                        return base.Dequeue().MyCompatitor;
                    }
                    else
                    {
                        throw new TimedOutException("ba li message!!!");
                    }
                }
            }
        }

        public override string ToString()
        {            
            string output = "\r\n______ the timed queue _______\r\n\r\n";
            foreach (var item in base.ToArray())
            {
                output +=  item  +  "\r\n";
            }

            return output + "\r\n";
        }

    }
}
