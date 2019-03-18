using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add(7);
            list.Add("avi");
            list.Add(true);
            list.Add(new Person() { Name="benny"});
            list.Add(7.8);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(list[1]);
            Console.WriteLine(list.Capacity);
            Console.WriteLine(list.Count);

            Console.WriteLine();
            Console.WriteLine(list[2]);
            list.RemoveAt(2);
            Console.WriteLine(list.Count);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            list.Insert(2,true);
            Console.WriteLine(list.Count);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            //Console.WriteLine( list.BinarySearch("avi"));

            Console.WriteLine();
            list.Remove(false);
            Console.WriteLine(list.Count);

            Console.WriteLine("\n\nQUEUE");
            Queue q = new Queue();
            q.Enqueue(1);
            q.Enqueue(true);
            q.Enqueue(new Person() { Name="dora"});

            Console.WriteLine(q.Dequeue());


            Console.WriteLine("\n\nHASHTABLE");
            Hashtable hash = new Hashtable();
            hash[1] = "avi";
            hash["avi"] = 1;
            hash[true] = new Person() {Name= "gil" };
            Console.WriteLine(hash[1]);
            Console.WriteLine(hash["avi"]);
        }
    }

    class Person
    {
        public string Name { get; set; }
    }
}
