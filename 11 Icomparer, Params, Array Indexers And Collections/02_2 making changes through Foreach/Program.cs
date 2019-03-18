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
            #region PERSONS
            //STUDENTS OBJECTS
            Student[] myClass = new Student[]{
                new Student{Id=1, Name="avi", Grade=80},
                new Student{Id=2, Name="dudu", Grade=50},
                new Student{Id=3, Name="zvi", Grade=90},
                new Student{Id=4, Name="beni", Grade=100},
            };

            foreach (Student item in myClass)
            {
                Console.WriteLine(item.Name);
                //item = new Student();   //THIS IS AN ERROR BECAUSE IENUMERATOR IS READ ONLY BUT THE PROPERTIES CAN BE CHANGED!!!
                
                if (item.Id % 2 ==0)
                {
                    //HERE WE CAN CHANGE THE NAME(FOR EXAMPLE) OF THE REAL COLLECTION !
                    item.Name += " the graet!";    
                }
            }

            Console.WriteLine();
            foreach (Student item in myClass)
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
