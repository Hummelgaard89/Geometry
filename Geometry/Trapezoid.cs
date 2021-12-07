using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class Trapezoid : Sides
    {
        public double sideC { get; set; }
        public double sideD { get; set; }
        //Uses the base of the class Sides, also added to this class is the two doubles of _c and _d.
        public Trapezoid(string name, double a, double b, double _c, double _d) : base(name, a, b)
        {
            sideC = _c;
            sideD = _d;
        }
        //Overrides the method in Sides to calculate the perimeter of a Trapezoid.
        public override double Caluculate_Perimeter()
        {
            double perimeter;
            perimeter = sideA + sideB + sideC + sideD ;
            return perimeter;
        }
        //Overrides the method in Sides to calculate the area of a Trapezoid without the user inputting the height, the height is calculated.
        public override double Calculate_Area()
        {
            double area;
            double s = (sideA + sideB - sideC + sideD)/2;
            double h = (2 / (sideA - sideC)) * (Math.Sqrt(s * (s - sideA + sideC) * (s - sideB) * (s - sideD)));
            area = ((sideA + sideC) / 2) * h;
            return area;
        }
    }
}
