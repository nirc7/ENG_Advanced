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
            try
            {
                int num1, num2;
                double result;
                Console.Write("insert num1: \t\t");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("will be devided by \t/  ");
                Console.Write("insert num2: \t\t");
                num2 = int.Parse(Console.ReadLine());
                result = num1 / num2;
                Console.WriteLine(result);
            }
            catch (Exception)
            {
                                
            }

            

        }
    }
}
