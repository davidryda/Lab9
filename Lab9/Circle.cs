using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    class Circle
    {
        public const double pi = Math.PI;
        private double radius;
        private double cir;
        private double area;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double GetCircumference()
        {
            cir = 2 * pi * radius;
            return cir;
        }
    
        public string GetFormattedCircumference()
        {
            return FormatNumber(cir);
        }

        public double GetArea()
        {
            area =  pi * radius * radius;
            return area;
        }

        public string GetFormattedArea()
        {
            return FormatNumber(area);
        }

        private string FormatNumber(double x)
        {
            string value = string.Format("{0:0.00}", x);
            return value;
        }
    }
}
