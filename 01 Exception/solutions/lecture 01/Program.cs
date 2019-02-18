using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Globalization;

namespace lecture12
{
    class Program
    {
        static void Main(string[] args)
        {
            //******************* to get the Infinity writing in english and not gibrish!
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US"); // English - US
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
            //*******************

            //RunExceptions();
            //TryCatch();
            //TryCatchExcptionsTypes();
            //BetweenFunctions();
            ThrowException();
            //Finally();
            //Finally2();
            //Checked();

        }

        private static void Checked()
        {
            int a = int.MaxValue;
            Console.WriteLine(a);
            a++;
            Console.WriteLine(a);
            a--;
            Console.WriteLine(a);
            //a = checked(a++);
            Console.WriteLine(a);


            int small = 0;
            long veryLong = 33333333333333333; //111 0110 0110 1100 0111 1101 0111 0100 1000 0011 0101 0101 0101 0101 -- 55 bit
            try
            {
                unchecked //default
                {
                    small = (int)veryLong; //1,954,764,117 = 0111 0100 1000 0011 0101 0101 0101 0101 -- first 32 bit
                    Console.WriteLine(small);
                }
                
                checked
                {
                    small = (int)veryLong;
                    Console.WriteLine(small);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Problem : ");
                Console.WriteLine(ex.Message);
            }
        }

        private static void Finally2()
        {
            try
            {
                Finally();
            }
            catch (Exception)
            {
                Console.WriteLine("in Finally2()");
            }
        }

        private static void Finally()
        {
            try
            {
                int num = 7 / int.Parse(Console.ReadLine());

            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                int a = int.Parse("a");
            }
            finally
            {
                Console.WriteLine("this will be shown even if there is no mathing catch block\n"+
                        "or an exception occure within the catch block!");
            }
            Console.WriteLine("END");
        }

        private static void ThrowException()
        {
            try
            {
                int num1 = 7;
                Console.WriteLine("insert a number in words (one\\zero): ");
                string num2 = Console.ReadLine();
                if (num2 == "zero")
                {
                    DivideByZeroException dvdExcp = 
                        new DivideByZeroException("u should not divide by zero and respect your teacher!");
                    throw dvdExcp;
                }
                else
                {
                    Console.WriteLine(num1);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);  
            }
            

        }

        static int ReadNum1()
        {
            Console.Write("insert num1: \t\t");

            //return int.Parse(Console.ReadLine());  //undo this remark to understand why it 
            //is important to write the tryCatch in the most inner function! - this
            // will catch the num1 error but will show the message for incorrect num2!!

            try
            {    
                return int.Parse(Console.ReadLine() );
            }
            catch (FormatException ex)
            {
                Console.WriteLine("num1 - wrong format, it will be set =0");
                return 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + " it will be set =0");
                return 0;
            }

            Console.WriteLine("ReadNum1 END"); //will never show
        }

        private static void BetweenFunctions()
        {
            try
            {
                int num1, num2;
                double result;
                num1 = ReadNum1();
                Console.WriteLine("will be devided by \t/  ");
                Console.Write("insert num2: \t\t");
                num2 = int.Parse(Console.ReadLine());
                result = num1 / num2;     //will generate exception when /0
                //result = (double)num1 / num2;            
                Console.WriteLine(result);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("the format of the num2 was incorrect - go to school!");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("the number is too big\\small - go to school!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("The END :) ");
        }

        private static void TryCatch()
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
                result = num1 / num2;     //will generate exception when /0
                //result = (double)num1 / num2;            
                Console.WriteLine(result);
            }
            catch (Exception Ex)
            {
                Console.WriteLine("something is wrong!!!");
                Console.WriteLine(Ex.Message );
                Console.WriteLine( Ex.StackTrace.Substring(Ex.StackTrace.Length - 8, 8));
            }

            Console.WriteLine("The END :) ");
        }

        private static void TryCatchExcptionsTypes()
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
                result = num1 / num2;     //will generate exception when /0
                //result = (double)num1 / num2;            
                Console.WriteLine(result);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("the format of the numbers was incorrect - go to school!");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("the number is too big\\small - go to school!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("The END :) ");
        }

        private static void RunExceptions()
        {
            int num1, num2;
            double result;
            Console.Write("insert num1: \t\t");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("will be devided by \t/  ");
            Console.Write("insert num2: \t\t");
            num2 = int.Parse(Console.ReadLine());
            result = num1 / num2;     //will generate exception when /0
            //result = (double)num1 / num2;            
            Console.WriteLine(result );
        }
    }
}
