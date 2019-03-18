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
            Person[] persons = new Person[] {
                new Person(){ID=2, Name="avi", Grade= 12 },
                new Person(){ID=1, Name="charlie" , Grade= 88},
                new Person(){ID=3, Name="benny" , Grade = 77},
            };

            foreach (var per in persons)
            {
                Console.WriteLine(per);
            }

            Array.Sort(persons);

            Console.WriteLine();
            foreach (var per in persons)
            {
                Console.WriteLine(per);
            }

            Console.WriteLine("PERSONS2");
            Person2[] persons2 = new Person2[] {
                new Person2(){ID=2, Name="avi" },
                new Person2(){ID=1, Name="charlie" },
                new Person2(){ID=3, Name="benny" },
            };

            foreach (var per in persons2)
            {
                Console.WriteLine(per);
            }

            Array.Sort(persons2, new NameComparer());

            Console.WriteLine();
            IComparer ic = new NameComparer();
            Console.WriteLine("???= "  + ic.Compare(persons2[0], persons2[1]));

            Console.WriteLine();
            foreach (var per in persons2)
            {
                Console.WriteLine(per);
            }


            Console.WriteLine();
            foreach (var per in persons)
            {
                Console.WriteLine(per);
            }

            Array.Sort(persons, new Person.GradeComparer());

            Console.WriteLine();
            foreach (var per in persons)
            {
                Console.WriteLine(per);
            }

        }
    }

    class Person :IComparable
    {
        public int ID { get; set; }
        public string Name{ get; set; }
        public int  Grade { get; set; }

        public int CompareTo(object obj)
        {
            return ID.CompareTo(((Person)obj).ID);
        }

        public override string ToString()
        {
            return $"{ID} {Name} {Grade}";
        }

        public class GradeComparer : IComparer
        {
            public GradeComparer()
            {
                Console.WriteLine();
            } 
            public int Compare(object x, object y)
            {
                return ((Person)x).Grade.CompareTo(((Person)y).Grade);
            }
        }
    }

    class NameComparer : IComparer
    { 
        public int Compare(object x, object y)
        {
            return ((Person2)x).Name.CompareTo(((Person2)y).Name);
        }
    }

    class Person2 
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"{ID} {Name}";
        }
    }
}
