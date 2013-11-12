using System;
using System.Linq;

namespace ShapesDefining
{
    class ProgramUI
    {
        static void Main()
        {
            Circle[] circles = new Circle[]
            {
                new Circle(3,3),
                new Circle(2,2.0),
                new Circle(4,4),
                new Circle(5,5),
                new Circle(3,3)
            };

            Triangle[] triangles = new Triangle[]
            {
                new Triangle(3,4),
                new Triangle(2.2, 2.5),
                new Triangle(11, 6.9),
                new Triangle(4,5),
                new Triangle(5,5),
            };

            Rectangle[] rectangles = new Rectangle[]
            {
                new Rectangle(6,4),
                new Rectangle(6,1),
                new Rectangle(6,2),
                new Rectangle(4,4),
                new Rectangle(9,4),
            };

            Console.WriteLine("\nCircles' surfaces:");
            Calculations(circles);

            Console.WriteLine("\nTriangles' surfaces:");
            Calculations(triangles);

            Console.WriteLine("\nRectangles' surfaces");
            Calculations(rectangles);
        }

        public static void Calculations(dynamic shapes)
        {
            foreach (var shape in shapes)
            {
                Console.WriteLine("{0}", shape.CalculateSurface());
            }
        }
    }
}