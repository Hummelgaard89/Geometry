using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class Parallelogram : Sides
    {
        public double angleV { get; set; }
        //Uses the base of the class Sides, also added to this class is the double _v.
        public Parallelogram(string name, double a, double b, double _v) : base(name, a, b)
        {
            angleV = _v;
        }
        //Overrides the method in Sides to calculate the perimeter of a Parallelogram.
        public override double Caluculate_Perimeter()
        {
            double perimeter;
            perimeter = (sideA * 2) + (sideB * 2);
            return perimeter;
        }
        //Overrides the method in Sides to calculate the area of a Parallelogram.
        public override double Calculate_Area()
        {
            double area;
            area = sideA * sideB * Math.Sin((Math.PI * angleV) / 180);
            return area;
        }
    }
}
