using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace abstract_demo2
{
    class RectAngle : Shape
    {
        public RectAngle(int width, int height)
            : base(height, width)
        {

        }

        public override double CalcArea()
        {
            return Height * Width;
        }
    }
}
