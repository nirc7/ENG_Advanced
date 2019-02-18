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
            //try
            //{
            //    int num1, num2;
            //    double result;
            //    Console.Write("insert num1: \t\t");
            //    num1 = int.Parse(Console.ReadLine());
            //    Console.WriteLine("will be devided by \t/  ");
            //    Console.Write("insert num2: \t\t");
            //    num2 = int.Parse(Console.ReadLine());
            //    result = num1 / num2;
            //    Console.WriteLine(result);
            //}
            //catch (Exception)
            //{

            //}


            //Console.WriteLine( ReadNum2());

            string input = "asd,123 er,78 y";
            //string[] output = input.Split(',');
            string[] output = input.Split(new char[] { ',' , ' '});
            foreach (var item in output)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            string input1 = "asd--123--er--78--y";
            //string[] output = input.Split(',');
            string[] output2 = input1.Split(new string[] { "--" },StringSplitOptions.RemoveEmptyEntries );
            foreach (var item in output2)
            {
                Console.WriteLine(item);
            }


            string input2 = "asd--123--er--78--y";
            string input3= input2.Replace("--", "||");
            Console.WriteLine(input3);


        }

        private static int ReadNum2()
        {
            while (true)
            {
                try
                {
                    return int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("ERR...");
                }
            }
        }

            private static int ReadNum()
        {
            try
            {
                return int.Parse(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine("only digit allowed! " + e.Message);
            }
            catch (OverflowException e)
            {
                Console.WriteLine("too something..." + e.Message);
            }
            catch (Exception)
            {
                Console.WriteLine("WORNG!");
            }

            return ReadNum();
        }
    }
}
