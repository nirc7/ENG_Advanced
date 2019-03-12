using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace abstract_demo2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Shape s = new Shape(); //ERROR
            Shape s = new RectAngle(7,8);
            Console.WriteLine( s.CalcArea());


            TriAngle t = new TriAngle(15, 100, 180);
            Console.WriteLine(t.CalcArea());

            Shape[] shapes = new Shape[2];
            shapes[0] = new TriAngle(10, 10, 100);
            shapes[1] = new RectAngle(20, 30);

            Console.WriteLine();
            PrintShapes(shapes);


            Console.WriteLine((shapes[0] as TriAngle).SumOfGrades); //not safe! we  can get an exception here if
                                                                    // shape[0] is not a triangle!
           

        }

        public static void PrintShapes(Shape[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i].CalcArea());
            }
        }
    }
}
