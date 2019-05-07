using System;


namespace ShapeAreasTerminalProgram
{
    public class Square : Shape
    {
        double side;

        public Square(double s)
        {
            side = s;
        }

        public override double Area()
        {
            return Math.Pow(side, 2);
        }

        public double GetSide()
        {
            return side;
        }

        public void SetSide(double s)
        {
            side = s;
        }

        public static Square GetSquareFromUser()
        {
            Console.WriteLine("Please enter the side length: ");

            string sideLength = Console.ReadLine();
            double side;

            if (double.TryParse(sideLength, out side))
            {
                return new Square(side);
            }
            else
            {
                Console.WriteLine("ERROR: input not a number");
                return null;
            }
        }

    }
}
