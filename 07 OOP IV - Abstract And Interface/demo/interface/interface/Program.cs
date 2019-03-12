using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace @interface
{

    public interface IMovable {
        int Move();
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 2,7,5,3,9,1,14};
            PrintArr(arr);
            Array.Sort(arr);
            PrintArr(arr);

            string[] arrStr = new string[] {"aa", "dd", "bb", "ab" };
            PrintArrStr(arrStr);
            Array.Sort(arrStr);
            PrintArrStr(arrStr);

            Person[] arrPerson = new Person[] {new Person(7,"avi"), new Person(2, "gil"), new Person(5, "benny") };
            PrintArrPer(arrPerson);
            Array.Sort(arrPerson);
            PrintArrPer(arrPerson);
            Person.SortById = false;
            Array.Sort(arrPerson);
            PrintArrPer(arrPerson);

            
            IComparable ic = new Person(33, "asdasd");
            Func(ic);
            Func(arrPerson[0]);

            Car[] cars = new Car[] {
                new Car(){LicensePlate=2,Model="BMW" },
                new Car(){LicensePlate=1,Model="KIA" },
            };

            foreach (var   car in cars)
            {
                Console.WriteLine(car.Model + ", " + car.LicensePlate);
            }
            Array.Sort(cars);
            Console.WriteLine();
            foreach (var car in cars)
            {
                Console.WriteLine(car.Model + ", " + car.LicensePlate);
            }


            Car c = new Car();

            IMovable[] ims = new IMovable[] {
                new Car(){LicensePlate=2,Model="BMW" },
                new Car(){LicensePlate=1,Model="KIA" },
                new Person(7,"avi"),
                new Person(2, "gil"),                
                c
            };

            Console.WriteLine();
            foreach (var imov in ims)
            {
                Console.WriteLine( imov.Move());
            }


        }

        private static void Func(IComparable ic)
        {
            Console.WriteLine(ic.CompareTo(new Person(18, "asdf") ));
        }

        private static void PrintArrPer(Person[] arrPerson)
        {
            foreach (var item in arrPerson)
            {
                Console.Write(item + " , ");
            }
            Console.WriteLine("\b");
        }

        private static void PrintArrStr(string[] arrStr)
        {
            foreach (var item in arrStr)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine("\b");
        }

        private static void PrintArr(int[] arr)
        {
            foreach (int item in arr)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine("\b");
        }
    }

    class Person : IComparable, IMovable
    {
        public static bool SortById = true;
        public int ID { get; set; }
        public string Name { get; set; }
        public Person(int i, string n)
        {
            ID = i;
            Name = n;
        }

        public override string ToString()
        {
            return "ID:" + ID + " Name:" + Name + " ";
        }

        public int CompareTo(object obj)
        {
            Person temp = obj as Person;
            if (temp == null)
	        {
		         throw new ArgumentException("wrong obj!=person"); 
	        }

            if (SortById)
            {
                if (this.ID < temp.ID)
                {
                    return -1;
                }
                else if (this.ID > temp.ID)
                {
                    return 1;
                }
                return 0;
            }
            else
            {
                return this.Name.CompareTo(temp.Name);
                //return this.Name.CompareTo(temp.Name) * (-1); //reverse sort
            }
            return 777; //not reachable code!


        }

        public int Move()
        {
            return new Random(ID).Next(3, 7);
        }
    }

    class Car : IComparable, IMovable
    {
        public string Model { get; set; }
        public int LicensePlate { get; set; }

        public int CompareTo(object obj)
        {
            return LicensePlate.CompareTo(((Car)obj).LicensePlate);
        }

        public override int GetHashCode()
        {
            return LicensePlate;
        }

        public int Move()
        {
            return new Random(LicensePlate).Next(150,250);
        }
    }
}
