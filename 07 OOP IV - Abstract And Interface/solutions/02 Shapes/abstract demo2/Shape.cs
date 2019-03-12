using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace abstract_demo2
{
    abstract class Shape 
    {
        int height, width;
        public int Height { get { return height; } set { height = value; } }
        public int Width { get { return width; } set { width = value; } }

        public Shape(int height, int width)
        {
            this.width = width;
            this.height = height;
        }

        public abstract double CalcArea();
    }
}
