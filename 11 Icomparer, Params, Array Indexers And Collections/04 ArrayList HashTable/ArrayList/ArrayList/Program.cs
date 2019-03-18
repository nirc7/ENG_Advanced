using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ArrayListNS
{
    class Person 
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return "ID=" + Id + " Name= " + Name;
        }

        public  class CompareID : IComparer
        {
            public int Compare(object o1, object o2)
            {
                return ((Person)o1).Id - ((Person)o2).Id;
            }
        }

        public class CompareName : IComparer
        {
            public int Compare(object o1, object o2)
            {
                return string.Compare( ((Person)o1).Name , ((Person)o2).Name);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add(new Person(){Id=1, Name="avi"});
            al.Add(new Person() { Id = 2, Name = "beny" });
            al.Add(new Person() { Id = 3, Name = "chico" });
            //al.Add(7);
           
            al.Insert(1, new Person() { Id = 4, Name = "bobo" });

            foreach (Person item in al)
            {
                Console.WriteLine( item);
            }
            Console.WriteLine();
            Person.CompareID ci = new Person.CompareID();
            al.Sort(ci);

            //al.Sort();    //ERROR because Person doesnt implement IComparable!

            foreach (Person item in al)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            al.Sort(new Person.CompareName());
            foreach (Person item in al)
            {
                Console.WriteLine(item);
            }

            al.Remove(al[2]);
            Console.WriteLine();
            foreach (Person item in al)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}
