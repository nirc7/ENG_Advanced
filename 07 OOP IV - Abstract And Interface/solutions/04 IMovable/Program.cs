using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abstract_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car();
            AnticCar t = new AnticCar();
            Golf g = new Golf();

            StartEverything(c);
            StartEverything(g);
            //StartEverything(t);
        }

        static void StartEverything(IMovable something)
        {
            something.Start();
        }
    }

    public abstract class Vehicle 
    {
        protected int NumOfWheels; // "real" field
        
        public abstract int Width { get;} // abstract prop
        public abstract int NumOfPassengers(); // abstract method

        public virtual void Print()
        {
            Console.WriteLine("Num of wheels {0}, Width {1}, Passengers {2}", NumOfWheels, Width, NumOfPassengers());
        }
    }

    interface IMovable
    {
        int Speed { get; set; }
        void Start();
    }

    class Car : Vehicle, IMovable
    {
        int carWidth;

        public override int Width
        {
            get { return carWidth; }
        }

        public override int NumOfPassengers()
        {
            return 5;
        }

        #region IDriveble Members

        public int Speed
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public void Start()
        {
            Console.WriteLine("Car is now started!");
        }

        #endregion
    }

    class AnticCar : Vehicle
    {
        public override int Width
        {
            get { return 100; }
        }

        public override int NumOfPassengers()
        {
            return 3;
        }
    }


    class Golf : IMovable
    {
        #region IDriveble Members

        public int Speed
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public void Start()
        {
            Console.WriteLine("Starting to swing...");
        }

        #endregion
    }

}
