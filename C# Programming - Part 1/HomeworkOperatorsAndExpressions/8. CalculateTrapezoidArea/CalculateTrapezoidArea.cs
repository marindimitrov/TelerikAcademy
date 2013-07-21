//Write an expression that calculates trapezoid's area 
//by given sides a and b and height h.

using System;

class CalculateTrapezoidArea
{
    static void Main()
    {
        Console.WriteLine("This program calculates the are of trapezoid, by predefined sides \"a\" and \"b\" and height \"h\".\n");
        Console.Write("Enter side \"a\": ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter side \"b\": ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter height \"h\": ");
        double h = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("The trapezoid's area is: {0}.", (((a + b) / 2) * h));
    }
}