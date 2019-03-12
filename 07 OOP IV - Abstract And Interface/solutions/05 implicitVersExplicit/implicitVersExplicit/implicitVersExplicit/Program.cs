using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace implicitVersExplicit
{
    class Program
    {
        static void Main(string[] args)
        {
            IPrintable[] arr = new IPrintable[] {
                new MyClass(),
                new MyClass2(),
                new MyClass2(),
                new MyClass()
            };

            MyClass m = new MyClass();
            m.Print();
            MyClass2 m2 = new MyClass2();
            //m2.Print(); //ERROR! can be accessed only through the interface!
            IPrintable i2 = m2;
            i2.Print();

            arr[0].Print();
            foreach (IPrintable item in arr)
            {
                item.Print();
            }

            Console.WriteLine();
            foreach (IMath item in arr)
            {
                item.Print();
            }
            Console.WriteLine("-----------------MyClass3");  
            MyClass3 m3 = new MyClass3();
            m3.Print();
            IPrintable i3 = m3;
            i3.Print();
            Console.WriteLine("-----------------MyClass4");  
            MyClass4 m4 = new MyClass4();
            m4.Print();
            IPrintable i4 = m4;
            i4.Print();
            Console.WriteLine("------------------MyClass5");  
            MyClass5 m5 = new MyClass5();
            m5.Print();
            IPrintable i5 = m5;
            i5.Print();
            Console.WriteLine("------------------MyClass6");
            MyClass6 m6 = new MyClass6();
            m6.Print();
            //IPrintable i6 = m6;//ERROR cant implicitly convert...!
            //IPrintable i6 = (IPrintable)m6; //ERROR too!! cant implicitly convert...!
            //i6.Print();
        }
    }

    public interface IPrintable
    {
        void Print();
    }

    public interface IMath
    {
        void Print();
    }

    class MyClass : IPrintable, IMath
    {

        public void Print()
        {
            Console.WriteLine("MyClass");
        }
    }

    class MyClass2 : IPrintable, IMath
    {

        void IPrintable.Print()
        {
            Console.WriteLine("MyClass2 : IPrintable.Print");
        }

        void IMath.Print()
        {
            Console.WriteLine("MyClass2 : IMath.Print");
        }
    }

    class MyClass3: MyClass2
    {
        public void Print() //no need for new because the print's 
        //in myClass2 are explicit and private!
        {
            //base.Print(); //ERROR - private!
            Console.WriteLine("MyClass3");
        }
    }

    class MyClass4 : MyClass2, IPrintable
    {
        public void Print() //no need for new because the print's 
        //in myClass2 are explicit and private!
        {
            //base.Print(); //ERROR - private!
            Console.WriteLine("MyClass4");
        }
    }

    class MyClass5 : MyClass
    {
        public new void Print() //need for new !
        {
            base.Print(); //public!
            Console.WriteLine("MyClass5");
        }
    }

    class MyClass6 
    {
        public void Print() 
        {
            Console.WriteLine("MyClass6");
        }
    }
}
