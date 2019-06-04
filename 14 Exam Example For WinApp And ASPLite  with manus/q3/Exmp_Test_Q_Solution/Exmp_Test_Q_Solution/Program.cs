using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exmp_Test_Q_Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            Cars myGrage = new Cars();
            myGrage[0] = new Car { Manufacturer = "Mazda", Model = "3", Price = 120000 };
            myGrage.AddCar(new Car { Manufacturer = "Skoda", Model = "Superb", Price = 180000 });
            myGrage[2] = new Car { Manufacturer = "Hyundai", Model = "i30", Price = 120000 };
            Console.WriteLine(myGrage);
            myGrage.CarPrice7();
            Console.WriteLine();
            myGrage.Name3();
        }
    }
}
