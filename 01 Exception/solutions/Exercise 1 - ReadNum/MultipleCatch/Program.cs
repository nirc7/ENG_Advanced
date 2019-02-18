using System;
using System.Collections.Generic;
using System.Text;

namespace MultipleCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter first number : ");
                int num1 = ReadNum();
                

                Console.WriteLine("Enter second number : ");
                int num2 = ReadNum();

                int divResult = num1 / num2;

                Console.WriteLine("{0} divied by {1} is {2} ", num1, num2, divResult);
            }
            catch (DivideByZeroException de)
            {
                Console.WriteLine("This is DivideByZero Excption : {0}", de.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("This is general Excption : {0}", ex.Message);
            }
            finally
            {
                Console.WriteLine("GOOD BYE in any case");          
                    
            }

            Console.WriteLine("END");
        }

        private static int ReadNum()
        {
            bool CanReturn = false;
            while (!CanReturn)
            {
                try
                {
                    return int.Parse(Console.ReadLine());
                }
                catch (FormatException fe)
                {
                    Console.WriteLine("This is Format Excption : {0}", fe.Message);
                }
                catch (OverflowException oe)
                {
                    Console.WriteLine("This is OverFlow Excption : {0}", oe.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("This is general Excption : {0}", ex.Message);
                }
                Console.WriteLine("Enter Number");
            }

            return 7; //only for compilation this code will never run!
        }



    }
}
