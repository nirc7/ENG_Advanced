using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objectCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add(7);
            list.Add("avi");
            list.Add(new Person() {ID=7, Name="benny" });

            Console.WriteLine(((Person)list[2]).ID);

            VectorGeneric<int> intsList = new VectorGeneric<int>();
            intsList.Add(5);
            Console.WriteLine(intsList[0]);
            intsList.ResetValueAtIndex(0);
            Console.WriteLine(intsList[0]);
            //intList.Add("charlie"); //ERROR!

            VectorGeneric<bool> boolsList = new VectorGeneric<bool>();
            boolsList.Add(true);
            Console.WriteLine( boolsList[0]);
            boolsList.ResetValueAtIndex(0);
            Console.WriteLine(boolsList[0]);

            VectorGeneric<string> stringsList = new VectorGeneric<string>();
            stringsList.Add("dora");
            Console.WriteLine(stringsList.Getvalue(0).IndexOf("o"));

            VectorGeneric<Person> personsList = new VectorGeneric<Person>();
            personsList.Add(new Person() { ID = 19, Name = "yaniv" });
            Console.WriteLine(personsList.Getvalue(0).Name);
            personsList.ResetValueAtIndex(0);
            Console.WriteLine(personsList.Getvalue(0) == null);

            personsList[2] = new Person() {ID=9, Name="eliran" };
            Console.WriteLine(personsList[2].Name);


            List<Person> plist = new List<Person>();
            Console.WriteLine(plist.Capacity);
            plist.Add(new Person() { ID = 3, Name = "chaim" });
            Console.WriteLine(plist[0].Name);
            plist.Add( new Person() {ID=4, Name="chris" });

            Point<int, double> p = new Point<int, double>() { x = 5, y = 7.8 };
            Console.WriteLine(p);

            int num = 7;
            long lo = num;
            double d = num;

            object o = num;
            long lo2 = (int)o;

            Dictionary<int, Person> dicip = new Dictionary<int, Person>();
            dicip[1] = new Person();
        }
    }

    class Point<X,Y>
    {
         public X x;
        public Y y { get; set; }

        public override string ToString()
        {
            return $"{x},{y}";
        }
    }

    class VectorINT
    {
        int[] nums = new int[2];
        int pointer = 0;

        public void Add(int num)
        {
            nums[pointer++] = num;
        }

        public int Getvalue(int index)
        {
            return nums[index];
        }
    }

    class VectorString
    {
        string[] values = new string[2];
        int pointer = 0;

        public void Add(string value)
        {
            values[pointer++] = value;
        }

        public string Getvalue(int index)
        {
            return values[index];
        }
    }

    class LimitedVector : List<Person>
    {
        public new void Add(Person item) {
            if (Count <= 10)
            {
                base.Add(item);
            }             
        }
    }

    class VectorGeneric<T>
    {
        T[] values = new T[4];
        int pointer = 0;

        public T this[int index]
        {
            get { return values[index]; }
            set {  values[index] =  value; }
        }
        public void ResetValueAtIndex(int index)
        {
            values[index] = default(T);
        }

        public void Add(T value)
        {
            values[pointer++] = value;
        }

        public T Getvalue(int index)
        {
            T val = default(T);
            T val1 = values[index];
            if (val == null)
            {
                if (values[index] == null)
                {
                    Console.WriteLine("empty");
                }                
            }
            Console.WriteLine( "defalut(T) = " +  (val==null));
            return values[index];
        }
    }

    class Person 
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
