//Write an expression that checks if given point (x,  y) 
//is within a circle K(O, 5).

using System;

class CheckIfPointIsInsideCircle
{
    static void Main()
    {
        Console.WriteLine("This program checks whether a point with coordinates \"x\" and \"y\" is inside a circle K(0,5).\n");
        Console.Write("Enter \"x\" coordinate of the point: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Enter \"y\" coordinate of the point: ");
        double y = double.Parse(Console.ReadLine());
        Console.WriteLine((x * x + y * y < 5 * 5) ? "The point is inside the circle.\n" :
            "The point isn't inside the circle.\n");
    }
}
