using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IPrintable
{
    public interface IPrintable
    {
        void Print();
    }

   
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("______________________Person Student______________________");
            Person p = new Person(1, "avi");
            p.Print();
            p = new Student(12, 2, "beni");
            p.Print();
            Student s = p as Student;
            s.Print();

            Console.WriteLine("______________________Shape RectAngle IPrintable______________________");
            Shape sh = new Shape(1, 2);
            sh.Print();
            sh= new RectAngle(10,12,1,2);
            sh.Print(); //will get only the shape.print
            IPrintable ip = sh;
            ip.Print();
            Console.WriteLine();
            RectAngle rec = sh as RectAngle;
            rec.Print();
            Console.WriteLine();
            rec = new RectAngle(1,2,3,4);
            rec.Print();

            Console.WriteLine("_____________________ColoredRectAngle_______________________");
            sh = new Shape(1, 2);
            sh.Print();
            sh = new ColoredRectAngle("red",10, 12, 1, 2);
            sh.Print(); //will get only the shape.print
            ip = sh;
            ip.Print();
            Console.WriteLine();
            ColoredRectAngle crec = sh as ColoredRectAngle;
            crec.Print();
            Console.WriteLine();
            crec = new ColoredRectAngle("red",1, 2, 3, 4);
            crec.Print();

            Console.WriteLine("_____________________ColoredRectAngleIP_______________________");
            sh = new Shape(1, 2);
            sh.Print();
            sh = new ColoredRectAngleIP("red", 10, 12, 1, 2);
            sh.Print(); //will get only the shape.print
            ip = sh;
            ip.Print();
            Console.WriteLine();
            ColoredRectAngleIP crec2 = sh as ColoredRectAngleIP;
            crec2.Print();
            Console.WriteLine();
            crec2 = new ColoredRectAngleIP("red", 1, 2, 3, 4);
            crec2.Print();

            Console.WriteLine("_____________________all together within array_______________________");
            object[] arr = new object[5];
            arr[0] = new Shape(7,8);
            arr[1] = new Person(2, "boni");
            arr[2] = new RectAngle(3, 2, 7, 8);
            arr[3] = new Student(99, 3, "joni");
            arr[4] = new ColoredRectAngle("red",3, 2, 7, 8);    //PAY ATTENTION to the printing through the IPrintable in the for loops
                                                                //this will print through the RectAngle.Print() !!!!

            //IPrintable[] arr3 = new IPrintable[5];
            //arr3 = arr as IPrintable[];       //returns null
            //arr3 = (IPrintable[])arr ;        //ERROR!
            IPrintable[] arr2 = new IPrintable[5];
            for (int i = 0; i < arr.Length; i++)
            {
                arr2[i] = arr[i] as IPrintable;
            }

            //both are good
            Console.WriteLine("______________PRINT1_____________________");
            PrintArr(arr);
            Console.WriteLine("______________PRINT2_____________________");
            PrintArr2(arr2);
            Console.WriteLine("______________END PRINT_____________________");


            Console.WriteLine("\n\n**********!!!\n");

            ((ColoredRectAngle)arr[4]).Print(); //PAY ATTENTION this is the ColoredRectAngle.Print() 
                                                //and this will print the Shape.Print + the color!!!
        }

        /// <summary>
        /// will print the array
        /// </summary>
        /// <param name="arr">shoudl contain array of IPrintable items</param>
        static void PrintArr2(IPrintable[] arr)
        {
            foreach (IPrintable item in arr)
            {
                Console.WriteLine();
                Console.WriteLine(item.GetType());
                item.Print();
            }
            Console.WriteLine("\n\n________again___________\n\n");
            for (int i = 0; i < arr.Length; i++)
            {
                    Console.WriteLine();
                    Console.WriteLine(arr[i].GetType());
                    arr[i].Print();   
            }
        }

        /// <summary>
        /// will print the array
        /// </summary>
        /// <param name="arr">shoudl contain array of IPrintable items</param>
        static void PrintArr(object[] arr)
        {
            foreach (IPrintable item in arr)
            {
                Console.WriteLine();
                Console.WriteLine(item.GetType());
                item.Print();
            }
            Console.WriteLine("\n\n________again___________\n\n");
            for (int i = 0; i < arr.Length; i++)
            {
                IPrintable ip = arr[i] as IPrintable;
                if (ip != null)
                {
                    Console.WriteLine();
                    Console.WriteLine(ip.GetType());
                    ip.Print();
                }
            }
        }
    }

    class Shape : IPrintable
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Shape(int x, int y)
        {
            X = x;
            Y = y;
        }
        #region IPrintable Members

        public void Print()
        {
            Console.WriteLine("x: {0}, y: {1}", X,Y);
        }

        #endregion
    }


    class RectAngle : Shape, IPrintable 
    {
        public int Width { get; set; }
        public int Hight { get; set; }
        public RectAngle(int w, int h, int x, int y) : base(x,y)
        {
            Width = w;
            Hight = h;
        }

        #region IPrintable Members

        void IPrintable.Print() //explicit interface can't be public!!!!
        {
            Console.WriteLine("------");
            base.Print();
            Console.WriteLine("width~{0}, hight~{1}", Width, Hight);
        }

        #endregion
    }

    class ColoredRectAngle : RectAngle
    {
        public string Color { get; set; }
        public ColoredRectAngle(string c, int w, int h, int x, int y) : base( w, h, x, y)
        {
            Color = c;
        }

        public void Print()
        {
            base.Print();       //although base is RectAngle! this is the Print of Shape because of the explicit
            //
            Console.WriteLine("color = {0}", Color);
        }

    }

    class ColoredRectAngleIP : RectAngle, IPrintable
    {
        public string Color { get; set; }
        public ColoredRectAngleIP(string c, int w, int h, int x, int y)
            : base(w, h, x, y)
        {
            Color = c;
        }

        void IPrintable.Print()
        {
            base.Print();       //although base is RectAngle! this is the Print of Shape because of the explicit
            Console.WriteLine("color = {0}", Color);
        }

    }


    class Person : IPrintable
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public Person(int i, string n)
        {
            ID = i;
            Name = n;
        }
        #region IPrintable Members

        public void Print() //implicit interface 
        {
            Console.WriteLine("id = {0}, name = {1}", ID,Name);
        }

        #endregion

     
    }

    class Student : Person      //dosnt inherits the IPrintable
    {
        public byte Grade { get; set; }
        public Student(byte g,int i, string n ) : base(i,n)
        {
            Grade = g;
        }

        public /*new*/ void Print() //a NEW method hiding the base one
        {
            base.Print(); 
            Console.WriteLine("grade= {0}",Grade);
        }
        
    }
}
