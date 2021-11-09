using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPark
{
    class Car
    {
        protected string label;
        protected double power;
        protected int year;

        public Car()
        {

        }
        public Car(string label, double power, int year)
        {
            this.label = label;
            this.power = power;
            this.year = year;
        }
    }
}

