using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exmp_Test_Q_Solution
{
    class Cars
    {
        List<Car> cars = new List<Car>();
        public Car this[int index]
        {
            set { cars.Insert(index,value); }
            get { return cars[index]; }
        }

        public void AddCar(Car c)
        {
            cars.Add(c);
        }

        public override string ToString()
        {
            string str = "";
            foreach (var item in cars)
            {
                str += item.ToString() + "\n";
            }
            return str;
        }

        public void CarPrice7()
        {
            var outString = from car in cars
                            where car.Price > Math.Pow(car.Manufacturer.Length, 7)
                            select car.Model;
            foreach (var item in outString)
            {
                Console.WriteLine(item);
            }
        }

        public void Name3()
        {
            var outString = from car in cars
                            where car.Manufacturer.Length > 3
                            select car.Manufacturer + " : " + (car.Manufacturer.Length - 4);

            foreach (var item in outString)
            {
                Console.WriteLine(item);
            }
        }
    }
}
