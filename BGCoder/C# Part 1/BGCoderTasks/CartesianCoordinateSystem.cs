using System;

class CartesianCoordinateSystem
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());

        if (x >= -2000000000001337 && x <= 2000000000001337 &&
            y >= -2000000000001337 && y <= 2000000000001337)
        {
            if (x > 0 && y > 0)
            {
                Console.WriteLine(1);
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine(2);
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine(3);
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine(4);
            }
            else if (x == 0 && y != 0)
            {
                Console.WriteLine(5);
            }
            else if (x != 0 && y == 0)
            {
                Console.WriteLine(6);
            }
            else
            {
                Console.WriteLine(0);
            }
        }
        else
        {
            Console.WriteLine("X or Y is out of the range.");
        }
    }
}