using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exmp_Test_Q_Solution
{
    class Car
    {
        private string manufacturer, model;
        private double price;

        public string Manufacturer
        {
            set { manufacturer = value; }
            get { return manufacturer; }
        }

        public string Model
        {
            set { model = value; }
            get { return model; }
        }

        public double Price
        {
            set { price = value; }
            get { return price; }
        }

        public override string ToString()
        {
            return "manufacturer : " + manufacturer + "\tmodel: " + model + "\tprice: " + price;
        }
    }
}
