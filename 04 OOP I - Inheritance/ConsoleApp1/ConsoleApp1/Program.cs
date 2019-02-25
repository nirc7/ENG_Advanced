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
            Person p = new Person(1,"avi");
            p.Print();

            Console.WriteLine();
            Student s = new Student();
            s.Print();
            Console.WriteLine();

            SuperStudent supS = new SuperStudent();
            SuperStudent supS2 = new SuperStudent(8);

        }
    }

    class SuperStudent: Student
    {
        public SuperStudent() : base(7)
        {
            Grade = 100;
            Console.WriteLine("supS");
        }
        public SuperStudent(int i) : base(i)
        {
            Console.WriteLine("supS");
        }

    }

    class Student /*derived*/ : Person //base
    {
        public int Grade { get; set; }

        public Student(int i):base(i, "cahflrie")
        {
            Console.WriteLine("ctor2 student");
        }


        public Student():base(2,"benny")
        {
            id = 99;
        }

        public new void Print()
        {
            base.Print();
            Console.WriteLine($"Grade={Grade}");
        }
    }

    class Person //base
    {
         protected int id;

        public string Name { get; set; }
        public int ID { get { return id; } set { id = value*2; } }

        //public Person()
        //{

        //}

        public Person(int i, string n)
        {
            ID = i;
            Name = n;
        }

        public void Print()
        {
            Console.WriteLine($"id={ID},name={Name}");
        }
    }
}
