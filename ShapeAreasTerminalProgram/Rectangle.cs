using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ShapeAreasTerminalProgram
{
    public class Rectangle : Shape
    {
        public double length;
        public double width;

        public Rectangle(double l, double w)
        {
            length = l;
            width = w;
        }
        public override double Area()
        {
            return length * width;
        }

        public double GetLength()
        {
            return length;
        }

        public void SetLength(double l)
        {
            length = l;
        }

        public double GetWidth()
        {
            return width;
        }

        public void SetWidth(double w)
        {
            width = w;
        }

        public static Rectangle GetRectangleFromUser()
        {
            Console.WriteLine("Please enter the width: ");
            string widthLength = Console.ReadLine();

            Console.WriteLine("Please enter the length:");
            string lengthS = Console.ReadLine();

            double width, length;

            if (double.TryParse(widthLength, out width) && double.TryParse(lengthS, out length))
            {
                return new Rectangle(length, width);
            }
            else
            {
                Console.WriteLine("ERROR: input not a number");
                return null;
            }
        }


    }
}
