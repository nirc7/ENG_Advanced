using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace anonymous_types
{
    class Program
    {
        static void Main(string[] args)
        {
            var myAnonymous = new { Age = 7, Name = "chipopo", Gender = true};
            Console.WriteLine(myAnonymous.Age);
            //myAnonymous.Age = 9;  //ERROR - read only!
            Console.WriteLine(myAnonymous);

            Console.WriteLine("myAnonymous.GetType() : " + myAnonymous.GetType());
            Console.WriteLine("myAnonymous.GetType().Name : " + myAnonymous.GetType().Name);
            Console.WriteLine("myAnonymous.GetType().BaseType : " + myAnonymous.GetType().BaseType);
            Console.WriteLine("myAnonymous.Age.GetType() : " + myAnonymous.Age.GetType());
            Console.WriteLine("myAnonymous.Name.GetType() : " + myAnonymous.Name.GetType());
            Console.WriteLine("myAnonymous.Gender.GetType() : " + myAnonymous.Gender.GetType());

            var myAnonymous2 = new { Age = 7, Name = "chipopo", Gender = true };
            Console.WriteLine("myAnonymous.GetType() : " + myAnonymous2.GetType());

            if (myAnonymous == myAnonymous2)
                Console.WriteLine("the same object/ref");
            else
                Console.WriteLine("not the same object/ref");

            if (myAnonymous.GetType() == myAnonymous2.GetType())
                Console.WriteLine("the same Type");
            else
                Console.WriteLine("not the same Type");

            if (myAnonymous.Equals(myAnonymous2)) //the same values? (not ref?)
                Console.WriteLine("the same Values");
            else
                Console.WriteLine("not the same Values");

            MyClass c = new MyClass();
            c.num = 7;
            MyClass c2 = new MyClass();
            c2.num = 7;
            Console.WriteLine(c.Equals(c2)); //the same ref?

            //anonymous collection
            var myCollection = new[] 
            {
                new {num1=8, num2=1.1},
                new {num1=9, num2=2.2},
                new {num1=10, num2=3.3}
                //new {num1="a", num2="a"} //Error type mismatch
            };

            Console.WriteLine(myCollection.GetType());
            Console.WriteLine(myCollection[0].GetType());
            var a = myCollection[0];
            Console.WriteLine(a);
            foreach (var item in myCollection)
            {
                Console.WriteLine(item);
            }
        }
    }

    class MyClass
    {
        public int num;
    }
}
