using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace jagged_array_students
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[][] school = new Student[3][];
            school[0] = new Student[] { new Student("a"), new Student("b") };
            school[1] = new Student[] { new Student("aa") };
            school[2] = new Student[] { new Student("aaa"), new Student("bbb"), new Student("ccc") };

            for (int i = 0; i < school.Length; i++)
            {
                for (int j = 0; j < school[i].Length; j++)
                {
                    Console.Write(school[i][j] + ", ");
                }
                Console.WriteLine();
            }
        }
    }

    class Student
    {
        public string Name { get; set; }

        public Student(string n)
        {
            Name = n;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
