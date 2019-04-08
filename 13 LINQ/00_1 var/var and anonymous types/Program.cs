using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace var_and_anonymous_types
{
    class Program
    {
        static void Main(string[] args)
        {
            //VAR
            var num = 7;
            var num2 = 1.23;
            var name = "chipopo";
            Console.WriteLine(num.GetType());
            Console.WriteLine(num2.GetType());
            Console.WriteLine(name.GetType());
            Console.WriteLine();

            //pay attention that the IDE already recognizes the item as int
            //move the mouse over the item and see that it is an int:)
            foreach (var item in new []{1,2,3,4})
            {
                Console.WriteLine(item.GetType());
            }

            Console.WriteLine();
            //pay attention that the IDE already recognizes the item as double
            foreach (var item in new[] { 1.1, 2, 3, 4 })
            {
                Console.WriteLine(item.GetType());
            }

            Console.WriteLine();
            //here the IDE shows the object type! BUT pay attention that the complier recognizes the real type!
            foreach (var item in new object[] { 1.1, "", 2, 3, 4 })
            {
                Console.WriteLine(item.GetType());
            }
        }
    }
}
