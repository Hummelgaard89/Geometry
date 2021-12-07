using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class Sides
    {
        public string name { get; set; }
        public double sideA { get; set; }
        public double sideB { get; set; }
        //Constructor of Sides.
        public Sides(string _name, double a, double b)
        {
            name = _name;
            sideA = a;
            sideB = b;
        }
        // common methods to be overritten by the child classes.
        public virtual double Caluculate_Perimeter()
        {
            return 0;
        }
        public virtual double Calculate_Area()
        {
            return 0;
        }
    }
}
