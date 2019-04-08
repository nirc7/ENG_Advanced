using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace anonymous_type
{
    class Program
    {
        static void Main(string[] args)
        {
            #region AnonymousType
            Console.WriteLine("\nAnonymousType");
            int[] arr2 = { 1, 3, 5, 7 };
            string[] days = { "none", "sunday", "monday", "tuesday", "wednesday", "thursday", "friday", "saturday" };

            var dayName = from x in arr2
                          select new {
                                  dayNumber = x,
                                  day_name = days[x]
                              };

            foreach (var item in dayName)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            foreach (var item in dayName)
            {
                Console.WriteLine(item.dayNumber +": means " +  item.day_name);
            }
            #endregion

            #region Students
            Console.WriteLine("\nStudents");
            List<Student> ls = Student.CreateClassOfStudents();
            var students = from student in ls
                           where student.Birthdate > new DateTime(2000, 1, 1)
                           orderby student.Grade descending
                           select new
                           {
                               SName = student.Name,
                               SGrade = student.Grade
                           };

            //foreach (Student student in students)   //ERROR type missmatch!!
            foreach (var student in students)
            {
                Console.WriteLine("name={0}, grade={1}", student.SName, student.SGrade);
            }
            
            #endregion

        }
    }

    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public byte Grade { get; set; }
        public DateTime Birthdate { get; set; }
        public byte Age { get; set; }
        public double Hight { get; set; }

        public override string ToString()
        {
            return string.Format("id={0}, name={1}, grade={2}", Id, Name, Grade);
        }

        static public List<Student> CreateClassOfStudents()
        {
            return new List<Student>
            {
                new Student{Id=1, Name="avi", Grade=80, Birthdate=new DateTime(2000,1,27)},
                new Student{Id=2, Name="dana", Grade=50, Birthdate=new DateTime(1990,7,30)},
                new Student{Id=3, Name="zina", Grade=90, Birthdate=new DateTime(2005,5,5)},
                new Student{Id=4, Name="beni", Grade=100, Birthdate=new DateTime(1992,11,22)},
            };
        
        }

    }
}
