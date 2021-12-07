using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class Square : Sides
    {
        //Uses the base name and double a, but sets the base b from sides to 0, this allows for inputting 2 values only instead of 3.
        public Square(string name, double a) : base(name, a, 0)
        {

        }
        //Overrides the method in Sides to calculate the perimeter of a Square.
        public override double Caluculate_Perimeter()
        {
            double perimeter;
            perimeter = sideA * 4;
            return perimeter;
        }
        //Overrides the method in Sides to calculate the area of a Square.
        public override double Calculate_Area()
        {
            double area;
            area = sideA * 2;
            return area;
        }
    }
}
