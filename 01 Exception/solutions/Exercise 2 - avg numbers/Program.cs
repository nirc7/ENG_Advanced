using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please insert your numbers space seperated\nand you can use the '-' to input a range:\n ");
            
            string input = "1 2 3 4-9 100-200";// Console.ReadLine();
            Console.WriteLine(input);
            Console.WriteLine();

            string[] strArr, strtemp;
            int sum = 0, count = 0;

            try
            {

                char[] delim = " ".ToCharArray();
                strArr = input.Split(delim);

                for (int index = 0; index <= strArr.Length - 1; index++)
                {
                    if (strArr[index].IndexOf("-") != -1)
                    {
                        delim = "-".ToCharArray();
                        strtemp = strArr[index].Split(delim);

                        for (int index1 = int.Parse(strtemp[0]); index1 <= int.Parse(strtemp[1]); index1++)
                        {
                            sum += index1;
                            count += 1;
                        }
                    }
                    else
                    {
                        sum += int.Parse(strArr[index]);
                        count += 1;
                    }
                }

                Console.WriteLine("The Average is: {0}", (((double)sum / count).ToString("0.00")) );
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("the number is too BIG!");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("the format is WrOnG!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR~!@#" + ex.Message);
            }
        }
    }
}
