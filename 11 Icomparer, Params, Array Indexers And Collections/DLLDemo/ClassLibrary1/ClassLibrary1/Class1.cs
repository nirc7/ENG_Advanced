using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
    }

    /// <summary>
    /// persin is ....
    /// </summary>
   public class Person
    {
        /// <summary>
        /// id is ....
        /// </summary>
        public int ID { get; set; }
        public string Name { get; set; }
        public int Grade { get; set; }


        /// <summary>
        /// ctor is ...
        /// </summary>
        /// <param name="i">i is </param>
        /// <param name="n">n is </param>
        public Person(int i ,  string n)
        {
            ID = i;Name = n;
        }

        public override string ToString()
        {
            return $"{ID}, {Name}";
        }
    }
}
