using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    class RightTriangle : Sides
    {
        //Uses the base of the class Sides, nothing added.
        public RightTriangle(string name, double a, double b) : base(name, a, b)
        {

        }
        //Overrides the method in Sides to calculate the perimeter of a RightTriangle only having 2 of the sides, the hypotenuse is calculated from sideA and sideB.
        public override double Caluculate_Perimeter()
        {
            double perimeter;
            double c = Math.Sqrt( (Math.Pow(sideA, 2) ) + (Math.Pow(sideB, 2) ) );
            perimeter = sideA + sideB + c;
            return perimeter;
        }
        //Overrides the method in Sides to calculate the area of a RightTriangle.
        public override double Calculate_Area()
        {
            double area;
            area = (sideA * sideB) / 2;
            return area;
        }
    }
}
