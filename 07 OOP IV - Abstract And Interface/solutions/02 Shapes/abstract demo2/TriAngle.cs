using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace abstract_demo2
{
    class TriAngle : Shape
    {
         public int SumOfGrades { get; set; }

        #region CONSTRUCTORS

         public TriAngle(int width, int height, int grades)
            :base(height, width)
        {
            SumOfGrades = grades;
        }

        #endregion

        public override double CalcArea()
        {
            return (Height * Width) / 2d;
        }

    }
}
