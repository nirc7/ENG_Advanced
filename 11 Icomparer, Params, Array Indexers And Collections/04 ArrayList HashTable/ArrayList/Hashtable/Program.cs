using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;


namespace HashtableNS
{
    class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return "ID=" + Id + " Name= " + Name;
        }

        public class CompareID : IComparer
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
                return string.Compare(((Person)o1).Name, ((Person)o2).Name);
            }
        }

        
        

    }

    class Program
    {
        static void Main(string[] args)
        {
            Hashtable hash = new Hashtable();
            hash["avi"] = new Person() { Id = 1, Name = "avi" };
            hash["beni"] = new Person() { Id = 2, Name = "beni" };
            hash["dani"] = new Person() { Id = 3, Name = "dani" };
            hash["dudu"] = "dudu";

            //Console.WriteLine(hash["dani"].);
            Console.WriteLine(     (   (Person)hash["beni"]).Id        );
            Console.WriteLine(((Person)hash["avi"]).GetHashCode());
            Console.WriteLine(((Person)hash["beni"]).GetHashCode());
            Console.WriteLine(((Person)hash["dani"]).GetHashCode());
            Console.WriteLine(hash.Contains("dana"));
            Console.WriteLine(hash.ContainsValue("beni"));
            Console.WriteLine(hash.ContainsValue("dudu"));

            Person p = new Person() { Id = 7, Name = "Dudi" };
            hash["Dudi"] = p;
            Console.WriteLine(((Person)hash["Dudi"]).Id);
            Console.WriteLine(hash.ContainsValue(p));

           

        }
    }
}
