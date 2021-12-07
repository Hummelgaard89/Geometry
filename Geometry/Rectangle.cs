using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class Rectangle : Sides
    {
        //Uses the base of the class Sides, nothing added.
        public Rectangle(string name, double a, double b) : base(name, a, b)
        {

        }
        //Overrides the method in Sides to calculate the perimeter of a Rectangle.
        public override double Caluculate_Perimeter()
        {
            double perimeter;
            perimeter = (sideA * 2) + (sideB * 2);
            return perimeter;
        }
        //Overrides the method in Sides to calculate the area of a Rectangle.
        public override double Calculate_Area()
        {
            double area;
            area = sideA * sideB;
            return area;
        }
    }
}
