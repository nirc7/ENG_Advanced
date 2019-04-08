using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQ_HW1
{
    class Boat
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }
        public int MaxSpeed { get; set; }
        public double Price { get; set; }

        public void PrintInfo()
        {
            Console.WriteLine("{0} {1} {2} {3} {4}.",
                Name, Price, Color, MaxSpeed, Year);
        }
    }
}
