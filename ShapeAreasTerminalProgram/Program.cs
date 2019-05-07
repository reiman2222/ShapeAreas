using System;

namespace ShapeAreasTerminalProgram
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter: \n" +
                "\t1 or Square \n" +
                "\t2 or Rectangle\n" +
                "\t3 or Triangle\n" +
                "\t4 or Hexagon\n" +
                "to compute the area of a shape (or exit to quit).\n");

            string input = Console.ReadLine().ToLower();

            while (!input.Equals("exit"))
            {
                Shape s = null;
                if (input.Equals("1") || input.Equals("square"))
                {
                    s = Square.GetSquareFromUser();
                }
                else if (input.Equals("2") || input.Equals("rectangle"))
                {
                    s = Rectangle.GetRectangleFromUser();
                }
                else if (input.Equals("3") || input.Equals("triangle"))
                {
                    s = Triangle.GetTriangleFromUser();
                }
                else if (input.Equals("4") || input.Equals("hexagon"))
                {
                    s = Hexagon.GetHexagonFromUser();
                }
                else
                {
                    Console.WriteLine("ERROR: Unrecognized input");
                }

                if(s != null)
                {
                    Shape.ShowArea(s);
                }

                Console.WriteLine("\nEnter another type of shape (or exit to quit)");
                input = Console.ReadLine().ToLower();
            }
        }
    }
}
