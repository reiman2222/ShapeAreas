using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShapeAreasTerminalProgram
{
    public abstract class Shape
    {
        abstract public double Area();

        public static void ShowArea(Shape s)
        {
            double area = s.Area();
            Console.WriteLine("The area of the shape is " + Math.Round(area, 5));
        }
    }
}
