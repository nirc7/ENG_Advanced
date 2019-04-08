using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQ_HW1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Boat> boats = new List<Boat>
            {
                // use initializer list instead of constructor
                new Boat{ Name="Dima", Color="Blue", MaxSpeed=200
                    , Price=1000000, Year=2010},
                new Boat{ Name="Santa Maria", Color="White", MaxSpeed=100
                    , Price=50000000, Year=1966},
                new Boat{ Name="Bella", Color="Red", MaxSpeed=350
                    , Price=500000, Year=2005},
                new Boat{ Name="Marmara", Color="White", MaxSpeed=50
                    , Price=5000, Year=2011},
            };

            // All LINQ queries return IEnumrable<T>...

            q1(boats);

            q2(boats);

            q3(boats);

            q4(boats);

            q5(boats);

        }

        private static void q5(List<Boat> boats)
        {
            Console.WriteLine("**********************");

            var white2005_2 = from b in boats
                              where b.Color == "White" && b.Year > 2005
                              select new { b.Color, b.Year };

            // what is var white2005_2?? it's IEnumrable<?> and it has extension methods (like ElementAt)!
            Console.WriteLine(white2005_2.ElementAt(0).Color);

            foreach (var boat in white2005_2)
            {
                Console.WriteLine(boat.GetType());
                Console.WriteLine("{0} {1}", boat.Color, boat.Year);
            }
        }

        private static void q4(List<Boat> boats)
        {
            Console.WriteLine("**********************");

            var white2005 = from b in boats
                            where b.Color == "White" && b.Year > 2005
                            select b;

            foreach (var boat in white2005)
            {
                boat.PrintInfo();
            }
        }

        private static void q3(List<Boat> boats)
        {
            Console.WriteLine("**********************");
            var byPrice = from b in boats
                          orderby b.Price ascending
                          select b;

            foreach (var boat in byPrice)
            {
                boat.PrintInfo();
            }
        }

        private static void q2(List<Boat> boats)
        {
            Console.WriteLine("**********************");
            var bySpeed = from b in boats
                          orderby b.MaxSpeed descending
                          select b;

            foreach (var boat in bySpeed)
            {
                boat.PrintInfo();
            }
        }

        private static void q1(List<Boat> boats)
        {
            var whites = from b in boats
                         where b.Color == "White"
                         orderby b.Price
                         select b;

            foreach (var boat in whites)
            {
                Console.WriteLine("{0} {1} {2}", boat.Name, boat.Color, boat.Price);
            }

            // this is what happens really behind the scenes... (extension methods + lambda expression)
            var whites2 = boats.Where(b => b.Color == "White").OrderBy(b => b.Price);
        }
    }
}
