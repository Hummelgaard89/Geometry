using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creates the list of objects from the geometry world.
            List<Sides> geometryList = new List<Sides>();
            //Adds two Squares to the list.
            geometryList.Add(new Square("Square 1", 4));
            geometryList.Add(new Square("Square 2", 8));
            //Adds two Rectangles to the list.
            geometryList.Add(new Rectangle("Rectangle 1" ,4, 6));
            geometryList.Add(new Rectangle("Rectangle 2", 8, 12));
            //Adds two Parralelograms to the list.
            geometryList.Add(new Parallelogram("Parallelogram 1", 3, 5, 20));
            geometryList.Add(new Parallelogram("Parallelogram 2", 6, 10, 40));
            //Adds two Trapezoids to the list.
            geometryList.Add(new Trapezoid("Trapezoid 1", 10, 9, 8, 9));
            geometryList.Add(new Trapezoid("Trapezoid 2", 20, 18, 16, 18));
            //Adds two Righttriangles to the list.
            geometryList.Add(new RightTriangle("RightTriangle 1", 4, 4));
            geometryList.Add(new RightTriangle("RightTriangle 2", 6, 8));
            //Writes the list with all the objects in the list.
            foreach (Sides item in geometryList)
            {
                Console.WriteLine(item.name + " has a perimeter of: "+ item.Caluculate_Perimeter());
                Console.WriteLine(item.name + " has an area of: " + item.Calculate_Area() + "\n");
            }
            //
            Console.ReadLine();
        }
    }
}
