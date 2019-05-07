using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ShapeAreasTerminalProgram
{
    public class Triangle : Shape
    {
        double baseLength;
        double height;

        public Triangle(double b, double h)
        {
            baseLength = b;
            height = h;
        }


        public override double Area()
        {
            return 0.5 * baseLength * height;
        }

        public double GetBaseLength()
        {
            return baseLength;
        }

        public void SetBaseLenght(double b)
        {
            baseLength = b;
        }

        public double GetHeight()
        {
            return height;
        }

        public void SetHeight(double h)
        {
            height = h;
        }

        public static Triangle GetTriangleFromUser()
        {
            Console.WriteLine("Please enter the base length: ");
            string baseS = Console.ReadLine();

            Console.WriteLine("Please enter the height:");
            string heightS = Console.ReadLine();

            double height, baseLength;

            if (double.TryParse(baseS, out baseLength) && double.TryParse(heightS, out height))
            {
                return new Triangle(baseLength, height);
            }
            else
            {
                Console.WriteLine("ERROR: input not a number");
                return null;
            }
        }
    }
}
