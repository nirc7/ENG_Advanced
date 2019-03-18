using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Arrays_Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] people = { new Person(33, "Nir"),
                                  new Person(50, "Avi"),
                                  new Person(10, "Zvi"),
                                  new Person(70, "Beni")};

            //Array.Sort(people);

            //Array.Sort(people, new Person.PersonComparerInverse());
            Array.Sort(people, new Person.PersonComparerAge());

            for (int i = 0; i < people.Length; i++)
            {
                Console.WriteLine(people[i].Name);
            }
        }
    }

    class Person : IComparable
    {
        int age;
        string name;
        public int Age { get { return age; } set { age = value; } }
        public string Name { get { return name; } set { name = value; } }

        public Person(int age, string name)
        {
            this.age = age;
            this.name = name;
        }

        #region IComparable Members

        public int CompareTo(object obj)
        {
            Person p = obj as Person;
            return name.CompareTo(p.name);
        }

        #endregion


        public class PersonComparerInverse : IComparer
        {
            #region IComparer Members

            public int Compare(object x, object y)
            {
                Person p1 = x as Person;
                Person p2 = y as Person;

                return -p1.Name.CompareTo(p2.Name);
            }

            #endregion
        }

       public class PersonComparerAge : IComparer
        {
            #region IComparer Members

            public int Compare(object x, object y)
            {
                Person p1 = x as Person;
                Person p2 = y as Person;

                return p1.Age.CompareTo(p2.Age);
            }

            #endregion
        }
    }

    

}
