using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals = new Animal[]
            {
                new Animal("snoopy", 20),
                new CatFamily(),
                new CatFamily(){Name="mitzi", Age=30, Color="white" },
                new Tiger(){Name="tigi", Stripes=true, Color="black", Age=25 },
                new SuperTiger(){Name="tigris", Stripes=false, Color="brown", Age=35 },
            };

            foreach (var animal in animals)
            {
                animal.Print();
                Console.WriteLine();
            }

            Console.WriteLine("________________");
            animals[3].Print();
            Console.WriteLine();
            ((Tiger)animals[3]).Print();
            Console.WriteLine();

            Console.WriteLine("________________");
            animals[4].Print();
            Console.WriteLine();
            ((Tiger)animals[4]).Print();
            Console.WriteLine();

            PrintNice(animals[3]);

            Console.WriteLine();

            Animal a1;
            if (new Random().Next(1,10) < 5 )
            {
                a1 = new Animal("chaya",20);
            }
            else
            {
                a1 = new CatFamily();
            }

            a1.Print();
            Console.WriteLine();

            //((SuperTiger)animals[3]).Print();

            if (animals[3] is SuperTiger)
            {
                Console.WriteLine("is supertiger");
            }
            if (animals[4] is SuperTiger)
            {
                ((SuperTiger)animals[4]).Color = "blue";
                ((SuperTiger)animals[4]).Speed = 200;
                Console.WriteLine("is supertiger");
            }

            SuperTiger st = animals[3] as SuperTiger;
            if (st!=null)
            {
                st.Speed = 200;
                st.Color = "blue";
            }

        }

        public static void PrintNice(Animal a)
        {
            Console.WriteLine("*****");
            a.Print();
            Console.WriteLine("*****");
        }
    }

    class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Animal(string n, int a)
        {
            Name = n;
            Age = a;
        }

        public virtual void Print()
        {
            Console.Write($"{Name}, {Age}");
        }
    }

    class CatFamily : Animal
    {
        public string Color { get; set; }

        public CatFamily() : base("garfield", 15)
        {
            Color = "orange";
        }

        public override void Print() {
            base.Print();
            Console.Write($" ,{Color}");
        }
    }

    class Tiger : CatFamily
    {
        public bool Stripes { get; set; }

        public new virtual void Print()
        {
            base.Print();
            Console.Write($" ,{Stripes}");
        }
    }

    class SuperTiger : Tiger
    {
        public int Speed { get; set; }

        public override void Print()
        {
            base.Print();
            Console.Write($" ,{Speed}");
        }
    }

}
