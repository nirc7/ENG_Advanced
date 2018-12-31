using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Files_And_Dirs
{
    class Program
    {
        static void Main(string[] args)
        {
            Directory.CreateDirectory("a");
            
            //File.CreateText("a\\a.txt"); //will create error  when 
            //deleting the directory!!!because the returned sw from the CreateText is not closed !!!!
            //or an error when trying to create it again in the next line!

            StreamWriter sw = File.CreateText("a\\a.txt");
            sw.WriteLine("123");
            sw.Close();
            StreamWriter sw1 = File.AppendText("a\\a.txt");
            sw1.WriteLine("456\r\n789");
            sw1.Close();
            Directory.Delete("a", true);

            if (Directory.Exists("a"))
                Console.WriteLine("Exists:a");
            Directory.CreateDirectory("a//b"); 


            File.CreateText("a.txt");
            //File.Delete("a.txt"); //ERROR because the handel is still open.
                                    //need to save it and then close it before deleting the file
            
            File.CreateText(@"a\b\a.txt");
            //File.CreateText(@"a/b/a.txt"); //ERROR ...another proccess
            File.CreateText("a\\b\\b.txt");
            File.CreateText("a//b//c.txt"); 
            File.CreateText("a/b/d.txt");
            //File.CreateText("a\b\f.txt");   //Error illegal chars because of the \special chars

            StreamWriter sw2 = new StreamWriter(@"a\a.txt");
            sw2.Write("1, ");
            sw2.Write("2, ");
            sw2.WriteLine("3, ");
            sw2.Write("4, ");
            sw2.Write("5, ");
            sw2.WriteLine("7, ");
            sw2.Close();


            StreamReader sr = new StreamReader(@"a\a.txt");
            string line;
            while ( (line = sr.ReadLine()) != null )
            {
                Console.WriteLine(line);
            }
        }
    }
}
