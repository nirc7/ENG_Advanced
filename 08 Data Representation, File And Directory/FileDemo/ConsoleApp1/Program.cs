using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader(@"file1.txt");
            reader.ReadLine();
            Console.WriteLine( reader.ReadToEnd());
            
            //Console.WriteLine(reader.ReadToEnd());
            reader.Close();

            //StreamWriter writer = new StreamWriter("dir1\\file2.txt");
            StreamWriter writer = new StreamWriter(@"dir1\file2.txt");
            writer.WriteLine("mashu1\r\nmashu2");
            writer.WriteLine("mashu3\r\nmashu4");
            writer.Close();

            Console.WriteLine( File.Exists(@"dir1\file2.txt"));

            File.AppendAllText("file3.txt","\r\ncoldplay2");

            Console.WriteLine(new StreamReader(@"dir1\file2.txt").ReadToEnd().IndexOf("mashu2"));

            Console.WriteLine("FILES AND DIRECTORY:");
            foreach (var item in Directory.GetFileSystemEntries("."))
            {
                Console.Write(item + " - ");
                FileInfo fi = new FileInfo(item);
                Console.WriteLine(fi.Extension);
            }
            Console.WriteLine();

            Console.WriteLine(Directory.GetCurrentDirectory());


        }
    }
}
