using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace abstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Base b = new Base(); //ERROR
           
            Base b = new Derived();
            b.Print();

            //derived2 d1 = new derived2(); //ERROR
            derived2 d2 = new Derived3();
            Console.WriteLine(d2.Num());
        }
    }

    abstract class Base
    {
        public int ID { get; set; }
        public abstract void Print();
        //instead of the following - think of a function which would return something
        //public virtual void Print()
        //{
        //    return;
        //}
    }

    class Derived : Base
    {
        public override void Print()
        {
            Console.WriteLine("print Derived");
        }
    }

    abstract class derived2 : Base
    {
        //dont have to implement Print in an abstract class!

        public abstract int Num();
    }

    class Derived3 : derived2
    {
        public override void Print()
        {
            Console.WriteLine("print Derived3");
        }

        public override int Num() { return 7; }
    }
}
