using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace interfaceDemo
{
    
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArr = new[] { 1,3,5,7,4,2,0};
            for (int i = 0; i < intArr.Length; i++ )
            {
                Console.Write(intArr[i] + ", ");
            }
            Console.WriteLine("\b\b ");
            Array.Sort(intArr);
            for (int i = 0; i < intArr.Length; i++)
            {
                Console.Write(intArr[i] + ", ");
            }
            Console.WriteLine("\b\b \n\n");

            Person[] pArr = new Person[3];
            pArr[0] = new Person(5,100);
            pArr[1] = new Person(2,20);
            pArr[2] = new Person(12,15);

            for (int i = 0; i < pArr.Length; i++)
                pArr[i].Print();

            Console.WriteLine("-sort by AGE--------------------");
            Array.Sort(pArr);

            for (int i = 0; i < pArr.Length; i++)
                pArr[i].Print();


            Console.WriteLine("-sort by ID--------------------");
            Person.sortById = true;
            Array.Sort(pArr);

            for (int i = 0; i < pArr.Length; i++)
                pArr[i].Print();

        }
    }

   

    public class Person : IComparable
    {
        private int age;
        public int ID { get; set; }
        public static bool sortById = false; 

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public Person(int age, int i)
        {
            Age = age;
            ID = i;
        }

        public Person()
            : this(0, 0)
        {

        }

        public void Print()
        {
            Console.WriteLine("Age: {0}, ID: {1}", Age, ID);
        }

        public int CompareTo(object obj)
        {
            Person p = (Person)obj;
            if (sortById)
            {
                if (ID< p.ID)
                    return -1;

                if (ID > p.ID  )
                    return 1;

                return 0;
            }
            else
            {
                if (Age < p.Age)
                    return -1;

                if (Age > p.Age)
                    return 1;

                return 0;
            }
            
        }
    }

}
