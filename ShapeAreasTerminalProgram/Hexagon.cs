using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ShapeAreasTerminalProgram
{
    public class Hexagon : Shape
    {
        double side;

        public Hexagon(double s)
        {
            side = s;
        }
        public override double Area()
        {
            return ((3 * Math.Sqrt(3)) / 2) * Math.Pow(side, 2); 
        }

        public double GetSide()
        {
            return side;
        }

        public void SetSide(double s)
        {
            side = s;
        }

        public static Hexagon GetHexagonFromUser()
        {
            Console.WriteLine("Please enter the side length: ");

            string sideLength = Console.ReadLine();
            double side;

            if (double.TryParse(sideLength, out side))
            {
                return new Hexagon(side);
            }
            else
            {
                Console.WriteLine("ERROR: input not a number");
                return null;
            }
        }

    }
}
