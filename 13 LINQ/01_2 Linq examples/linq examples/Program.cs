using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace linq_examples
{
    class Program
    {
        static void Main(string[] args)
        {
            #region STRINGS
            //STRINGS
            Console.WriteLine("\nSTRINGS");
            string[] names = { "beni", "dana", "zvi", "danny", "daniel", "avi", "danuba", "dan" };

            var short_danies = from name in names
                               where name.StartsWith("dan") && name.Length <= 5
                               select name;

            Console.WriteLine("short_danies:");
            foreach (string item in short_danies)
            {
                Console.WriteLine(item);
            }
            #endregion

            #region PERSONS
            //STUDENTS OBJECTS
            Console.WriteLine("\nSTUDENTS OBJECTS");
            List<Student> myClass = new List<Student>
            {
                new Student{Id=1, Name="avi", Grade=80},
                new Student{Id=2, Name="dudu", Grade=50},
                new Student{Id=3, Name="zvi", Grade=90},
                new Student{Id=4, Name="beni", Grade=100},
            };

            var students = from student in myClass
                           where student.Grade > 60
                           select student;

            foreach (Student item in students)
            {
                Console.WriteLine(item);
            }
            #endregion

            #region MATH
            Console.WriteLine("\nMATH");
            int[] arr = { 4, 16, 25, 49 };
            
            var nums = from num in arr
                       select Math.Sqrt(num);
            //instead we can use the following extension method!
            foreach (var item in arr.Select(x => Math.Sqrt(x) )  )
            {
                Console.Write(item.GetType() + ",\t ");
                Console.WriteLine(item);
            }

            Console.WriteLine("\n");
            arr = new int[] { 7, 17, 27, 49 };
            nums = from num in arr
                   select Math.Sqrt(num);

            foreach (var item in nums)
            {
                Console.Write(item.GetType() + ",\t ");
                Console.WriteLine(item);
            }

            #endregion

            #region DifferentReturnType
            Console.WriteLine("\nDifferentReturnType");
            int[] arr2 = {1,3,5,7 };
            string[] days = {"none","sunday" ,"monday" ,"tuesday" ,"wednesday" ,"thursday" ,"friday", "saturday" };

            var dayName = from x in arr2
                          select days[x];

            foreach (string item in dayName)
            {
                Console.WriteLine(item);
            }

            #endregion


        }
    }

    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public byte Grade { get; set; }
        public override string ToString()
        {
            return string.Format("id={0}, name={1}, grade={2}", Id,Name,Grade);
        }
    }
}
