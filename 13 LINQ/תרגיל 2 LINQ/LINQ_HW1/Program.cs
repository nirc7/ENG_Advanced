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
                    , Price=5000, Year=2010},
            };

            // All LINQ queries return IEnumrable<T>...


            q1(boats);

            //q2(boats);

            //q3(boats);

            //q4(boats);

            //q5(boats);

            //q6(boats);

            //q7(boats);

            //q8(boats);

        }

        private static void q8(List<Boat> boats)
        {
            Console.WriteLine("\n************************");
            string[] colors = { "Red", "Blue", "Black", "White", "Yellow" };
            //join + into = group join of the outer table - like left outer join!
            var BoatsPerColorInList =
                from c in colors
                join b in boats on c equals b.Color
                into bc
                select new { COLOR = c, BOAT = bc };

            foreach (var group in BoatsPerColorInList)
            {
                Console.WriteLine(group.COLOR);
                foreach (var boat in group.BOAT)
                {
                    Console.WriteLine("\t" + boat.Name);
                }
            }
        }

        private static void q7(List<Boat> boats)
        {
            Console.WriteLine("\n************************");
            string[] colors = { "Red", "Blue", "Black", "White", "Yellow" };

            //join + into = group join of the outer table - like left outer join!
            var CountBoatsPerColorInList = from c in colors
                                           join b in boats on c equals b.Color 
                                           into bc
                                           select new {COLOR=c,BOAT=bc.Count() };
                                          
            foreach (var group in CountBoatsPerColorInList)
            {
                Console.WriteLine(group.COLOR + ": " + group.BOAT );
            } 
        }
  
        private static void q6(List<Boat> boats)
        {
            Console.WriteLine("\n************************");
            var CountBoatsPerColor = from b in boats
                                     group b by b.Color into g
                                     select new { COLOR = g.Key, COUNT = g.Count() };
            foreach (var group in CountBoatsPerColor)
            {
                Console.WriteLine(group.COLOR + " : " + group.COUNT);
            }
        }

        private static void q5(List<Boat> boats)
        {
            Console.WriteLine("\n************************");
            var PrincePerYear = from b in boats
                                group b by b.Year into g
                                select new { YEAR = g.Key, AVERAGE = g.Average(b => b.Price) };

            foreach (var group in PrincePerYear)
            {
                Console.WriteLine(group.YEAR + ": " + group.AVERAGE);
            }
        }

        private static void q4(List<Boat> boats)
        {
            Console.WriteLine("************************");

            var byColor = from b in boats
                          orderby b.Color
                          group b by b.Color;

            foreach (var groups in byColor)
            {
                Console.WriteLine("\t" + groups.Key);

                foreach (var item in groups)
                {
                    item.PrintInfo();
                }
            }
        }

        private static void q3(List<Boat> boats)
        {
            //Console.WriteLine("************************");
            //double sumOfAllPrices = boats.Sum(b => b.Price);
            //Console.WriteLine("Sum of prices is: {0}", sumOfAllPrices);

            //double sumOfAllPrices2 = (from b in boats
            //                          select b).Sum(b => b.Price);
            //Console.WriteLine("Sum of prices is: {0}", sumOfAllPrices2);

            double sumOfAllPrices3 = (from b in boats
                                      select b.Price).Sum();
            Console.WriteLine("Sum of prices is: {0}", sumOfAllPrices3);
        }

        private static void q2(List<Boat> boats)
        {
            Console.WriteLine("************************");
            double averageSpeed = (from b in boats
                                   select b.MaxSpeed).Average();
            Console.WriteLine("\nThe average speed is : " + averageSpeed);

            //double averageSpeed2 = boats.Average(b => b.MaxSpeed);
            //Console.WriteLine("\nThe average speed is : " + averageSpeed2);

            
        }

        private static void q1(List<Boat> boats)
        {
            Console.WriteLine("*********************");

            var q = from b in boats
                    where b.MaxSpeed > 100
                    select b;

            foreach (var item in q)
            {
                item.PrintInfo();
            }
            int temp = boats[3].MaxSpeed;
            boats[3].MaxSpeed = 1000;

            foreach (var item in q)
            {
                item.PrintInfo();
            }

            boats[3].MaxSpeed = temp;
        }
    }
}
