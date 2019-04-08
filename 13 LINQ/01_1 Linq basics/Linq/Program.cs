using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace LinqNS
{
    class Program
    {
        static void Main(string[] args)
        {
            func();

            //VERSION1_Create_delegate_using_Func();

            //VERSION2_Create_lambda_expression_using_Func();

            //VERSION3_LINQ();

            //VERSION3_LINQ_on_Person_array();

            func2();
        }

        private static void func2()
        {
            // LINQ on Person array
            Student[] students =
            {
               new Student{ Age =22, Name ="Nir", Grade = 100, Course="CS"},
               new Student { Age = 30, Name="Bla",Grade = 99, Course="bio"},
               new Student { Age = 10, Name = "YYY",Grade = 98, Course="math"}
            };

            //opt1 - not good
            //var greaterThan99 = from stu in students
            //                    where stu.Grade >= 99
            //                    select stu;

            //foreach (var student in greaterThan99)
            //{
            //    Console.WriteLine(student.Grade + ", " + student.Name + ", " + student.Course);
            //}

            //opt2 - not good
            //var greaterthan99 = from stu in students
            //                    where stu.Grade >= 99
            //                    select stu.Grade + "," + stu.Name + "," + stu.Course;

            //foreach (var student in greaterthan99)
            //{
            //    Console.WriteLine(student.Split(',')[1] + ", " + student.Split(',')[0]);
            //}


            //opt3 - not good
            //var greaterThan99 = from stu in students
            //                    where stu.Grade >= 99
            //                    select new RetunData() { Name = stu.Name, Grade = stu.Grade, Course = stu.Course };

            //foreach (var student in greaterThan99)
            //{
            //    Console.WriteLine(student.Grade+5 + ", " + student.Name + ", " + student.Course);
            //}


            //opt4 - good
            var greaterThan99 = from stu in students
                                where stu.Grade >= 99
                                orderby stu.Name descending
                                select new
                                {
                                    StuName = stu.Name,
                                    StuGrade = stu.Grade,
                                    stu.Course
                                };

            foreach (var student in greaterThan99)
            {
                Console.WriteLine(student.StuGrade + 5 + ", " + student.StuName + ", " + student.Course);
            }

            var stam = students.Max(stu => stu.Grade);

            var greaterThan99AsArray = (from stu in students
                                where stu.Grade >= 99
                                orderby stu.Name descending
                                select new
                                {
                                    StuName = stu.Name,
                                    StuGrade = stu.Grade,
                                    stu.Course
                                }).ToArray();

            Console.WriteLine(greaterThan99AsArray[0].StuName + ", "+ greaterThan99AsArray[0].Course);

        }

        private static void func()
        {
            //DATA SOURCE
            int[] nums = { 1, -2, 3, -4, 7, 10, -12 };

            var even = from num in nums
                       where num % 2 == 0 && num > 4
                       select (num + 2).ToString() + "!";
            nums[1] = 14;
            foreach (var n in even)
            {
                Console.WriteLine(n);
            }


        }

        private static void VERSION1_Create_delegate_using_Func()
        {
            //DATA SOURCE
            int[] nums = { 1, -2, 3, -4, 7, 10, -12 };

            // VERSION 1 - Create delegate using Func
            //***********
            Func<int, bool> filter = delegate (int num)
            {
                if (num > 0)
                    return true;
                return false;
                //return num > 0;
            };

            var positives = nums.Where(filter); //(differred execution - done only when the foreach is called! (GetEnumerator) )

            foreach (var item in positives)
            {
                Console.WriteLine(item);
            }
        }

        private static void VERSION2_Create_lambda_expression_using_Func()
        {
            //DATA SOURCE
            int[] nums = { 1, -2, 3, -4, 7, 10, -12 };

            // VERSION 2 - Create lambda expression using Func
            //***********

            Func<int, bool> filter = x => x > 0;

            //var positives = nums.Where(filter);
            var positives = nums.Where(x => x > 0);

            foreach (var item in positives)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            IEnumerable<int> iE = nums.Where(filter);

            foreach (int item in iE)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            int[] arr = nums.Where(filter).ToArray(); //immediate execution using the ToArray() or ToList()

            foreach (int item in arr)
            {
                Console.WriteLine(item);
            }
        }

        private static void VERSION3_LINQ()
        {
            //DATA SOURCE
            int[] nums = { 1, -2, 3, -4, 7, 10, -12 };

            // VERSION 3 - LINQ

            //QUERY DEFINITION
            var positives = from x in nums
                            where x > 0
                            select x + 2;

            //QUERY EXECUTION
            foreach (var item in positives)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            IEnumerable<int> positives2 = from x in nums
                                          where x > 0
                                          select x + 2;

            foreach (var item in positives2)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            int[] positives3 = (from x in nums
                                where x > 0
                                select x + 2).ToArray();

            foreach (var item in positives3)
            {
                Console.WriteLine(item);
            }
        }

        private static void VERSION3_LINQ_on_Person_array()
        {
            // LINQ on Person array
            Person[] persons =
            {
               new Person{ Age =22, Name ="Nir"},
               new Person { Age = 30, Name="Bla"},
               new Person { Age = 10, Name = "YYY"}
            };

            Console.WriteLine();
            var grown_ups = from x in persons
                            where x.Age > 20
                            select x.Name;

            foreach (var item in grown_ups)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            var grown_ups2 = from x in persons
                             where x.Age > 20
                             select x;

            foreach (var item in grown_ups2)
            {
                Console.WriteLine(item.Age);
            }
        }

    }



    class Person
    {
        public byte Age { get; set; }
        public string Name { get; set; }

    }

    class Student : Person
    {
        public int Grade { get; set; }
        public string Course { get; set; }

        public override string ToString()
        {
            return base.ToString() + $" {Grade},{Course}";
        }
    }

    class RetunData
    {
        public string Name { get; set; }
        public int Grade { get; set; }
        public string Course { get; set; }
    }
}
