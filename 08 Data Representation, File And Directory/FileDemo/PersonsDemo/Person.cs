using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonsDemo
{
    class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Grade { get; set; }

        public Person(int i, string n, int g)
        {
            ID = i; Name = n; Grade = g;
        }

        public string PersonAsString()
        {
            return $"{ID},{Name},{Grade}";
        }

        public string PersonAsLabelStr()
        {
            return $"{ID ,-10}| { Name,-10}| {Grade+" ",-10}";
        }
    }
}
