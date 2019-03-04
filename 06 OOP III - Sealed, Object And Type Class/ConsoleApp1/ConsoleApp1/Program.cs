using System;
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
            Person p = new Person() { ID = 7, Name = "avi" };
            Console.WriteLine(p.ToString());
            Console.WriteLine(p);

            Console.WriteLine();
            Student s = new Student() { ID = 8, Name = "benny", Grade = 99, StudentNumber = 123 };
            Console.WriteLine(s);  // reference is Object.ToString()
                                   //public void Console.WriteLine(object o)
                                   //{
                                   // o.ToString() --> console
                                   //}

            Console.WriteLine(s.ToString()); // reference is Student

            Console.WriteLine(Add(2, 3));
            //Console.WriteLine(2+3);

            Console.WriteLine(p.GetHashCode());
            Console.WriteLine(s.GetHashCode());

            Person p2 = p;
            Console.WriteLine(p2.GetHashCode() == p.GetHashCode());
            Person p3 = new Person() { ID = 7 };

            Console.WriteLine(p.Equals(p3));//True

            Console.WriteLine(p.GetType().Name);
            Console.WriteLine(s.GetType());

            Car c = new Car() { LicensePlate = 7 };

            Console.WriteLine(p.Equals(c));


            Console.WriteLine();

            Type t1 = p.GetType();
            Type t2 = typeof(Person);

            Console.WriteLine(t1.Name);
            Console.WriteLine(t1.IsClass);
            Console.WriteLine(t1.IsPublic);
            Console.WriteLine(t1.Namespace);

            foreach (var perMethods in t1.GetMethods())
            {
                Console.WriteLine(perMethods);
            }

            Console.WriteLine();
            foreach (var perMembers in t1.GetMembers())
            {
                Console.WriteLine(perMembers);
            }


        }
        static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}


class Car
{
    public string Model { get; set; }
    public int LicensePlate { get; set; }

    public override int GetHashCode()
    {
        return LicensePlate;
    }
}


class Person : Object
{
    public int ID { get; set; }
    public string Name { get; set; }

    public override string ToString()
    {
        return "id= " + ID + " name= " + Name;
    }

    public override int GetHashCode()
    {
        return ID;
    }

    public override bool Equals(object obj)
    {
        //return GetHashCode() == obj.GetHashCode();
        if (obj is Person)
        {
            return GetHashCode() == obj.GetHashCode();
        }
        return false;

    }
}

class Student : Person
{
    //int grade;
    //public int Grade { get { return grade; } }
    public int Grade { get; set; }
    public int StudentNumber { get; set; }

    public new string ToString()
    {
        return base.ToString() + " Grade= " + Grade;
    }

    public override int GetHashCode()
    {
        return StudentNumber + base.GetHashCode();
    }

}
    
