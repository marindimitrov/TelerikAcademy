//Write an expression that checks for given point (x, y) 
//if it is within the circle K( (1,1), 3) and out of the 
//rectangle R(top=1, left=-1, width=6, height=2).

using System;

class PointInCircleOutRectangle
{
    static void Main()
    {
        Console.WriteLine("This program checks whether a point with coordinates \"x\" and \"y\" is inside a circle K((1,1)3) and out of rectangle R(top=1, left=-1, width=6, height=2).\n");
        Console.Write("Enter \"x\" coordinate of the point: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Enter \"y\" coordinate of the point: ");
        double y = double.Parse(Console.ReadLine());

        if (x * x + y * y < 5 * 5)
        {
            if (x < -1)
            {
                if (y < -1)
                {
                    if (y > 1)
                    {
                        Console.WriteLine("The point is inside the required zone.\n");
                    }
                    else
                    {
                        Console.WriteLine("The point isn't inside the required zone.\n");
                    }
                }
                else
                {
                    Console.WriteLine("The point isn't inside the required zone.\n");
                }
            }
            else
            {
                Console.WriteLine("The point isn't inside the required zone.\n");
            }
        }
        else
        {
            Console.WriteLine("The point isn't inside the required zone.\n");
        }
    }
}
