using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Indexers
{
    class Program
    {
        static int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        static void Main(string[] args)
        {

            Console.WriteLine("{1}{0}{2}", "avi", 4, true);
            #region params
            //{
            //    Console.WriteLine("\n\n_______________params____________________");
                GetParamsIntMethod(10, 1, 2, 3, 4);
            //    //automatically converted to the command bellow
                GetParamsIntMethod(new int[] { 10, 1, 2, 3, 4 });
            //    GetParamsObjectMethod(10, "1", "2", 3, "4");
            //    //automatically converted to the command bellow
            //    GetParamsObjectMethod(new object[] { 10, "1", "2", 3, "4" });
            //}
            #endregion

            #region indexers
            {
                Console.WriteLine("\n\n_______________indexers____________________");
                Console.WriteLine();
                Garage myGarage = new Garage();

                myGarage[0] = new Car { Color = "Red", Speed = 100 };
                //myGarage.SetCar(0 , new Car { Color = "Red", Speed = 100 });
                myGarage[1] = new Car { Color = "White", Speed = 44 };
                myGarage[2] = new Car { Color = "White", Speed = 33 };
                myGarage[3] = new Car { Color = "Red", Speed = 88 };
                myGarage[4] = new Car { Color = "Black", Speed = 77 };

                Console.WriteLine(myGarage[0].Color);
                //Console.WriteLine(myGarage.GetCar(0).Color);

                Car[] reds = myGarage["Red"];
                for (int i = 0; i < reds.Length; i++)
                {
                    Console.WriteLine(reds[i].Speed);
                }

                Console.WriteLine();
                Car cRed100 = myGarage["Red", 100];
                if (cRed100 != null)
                {
                    Console.WriteLine("this is red 100\n");
                }
                else
                {
                    Console.WriteLine("no red 100");
                }

            }
            #endregion


        }

        #region Params

        public static void GetParamsIntMethod(params int[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine(args[i]);
            }
        }

        public static void GetParamsObjectMethod(params object[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine(args[i]);
            }
        }
        #endregion



        class Car
        {
            public int Speed { get; set; }
            public string Color { get; set; }
        }


        class Garage
        {
            Car[] cars = new Car[5];

            //public Car GetCar(int index)
            //{ return cars[index]; }

            //public void SetCar(int index, Car c)
            //{
            //    cars[index] = c;
            //}

            public Car this[int index]
            {
                get { return cars[index]; }
                set { cars[index] = value; }
            }

            public Car[] this[string indexColor]
            {
                get
                {
                    int count = 0;
                    for (int i = 0; i < cars.Length; i++)
                    {
                        if (cars[i].Color == indexColor)
                        {
                            count++;
                        }
                    }

                    Car[] colorCars = new Car[count];
                    count = 0;
                    for (int i = 0; i < cars.Length; i++)
                    {
                        if (cars[i].Color == indexColor)
                        {
                            colorCars[count] = cars[i];
                            count++;
                        }
                    }

                    return colorCars;
                }
                //set { /* set the specified index to value here */ }
            }

            public Car this[string color, int speed]
            {
                get
                {
                    for (int i = 0; i < cars.Length; i++)
                    {
                        if (cars[i].Color == color && cars[i].Speed == speed)
                        {
                            return cars[i];
                        }
                    }
                    return null;
                }
                //set { /* set the specified index to value here */ }
            }



        }
    }
}
