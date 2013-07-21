//Write a program that reads the coefficients a, b and c 
//of a quadratic equation ax2+bx+c=0 and solves it 
//(prints its real roots).

using System;

class QuadraticEquationSolution
{
    static void Main()
    {
        Console.WriteLine("This program solves quadratic equation, by specific parameters \"a\", \"b\" and \"c\":");
        Console.Write("Enter parameter \"a\": ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter parameter \"b\": ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter parameter \"c\": ");
        double c = double.Parse(Console.ReadLine());

        double d = b * b - 4 * a * c;
        if (d > 0)
        {
            if (b % 2 == 0)
            {
                d = (b / 2) * (b / 2) - 4 * a * c;
                Console.WriteLine("The equation has two real roots: X1 = {0:0.000} and X2 = {1:0.000}",
                    (-(b / 2) + Math.Sqrt(d)) / a, (-(b / 2) - Math.Sqrt(d)) / a);
            }
            else
            {
                Console.WriteLine("The equation has two real roots: X1 = {0:0.000} and X2 = {1:0.000}",
                    (-b + Math.Sqrt(d)) / (2 * a), (-b - Math.Sqrt(d)) / (2 * a));
            }
        }
        else if (d == 0)
        {
            Console.WriteLine("The equation has one real root: {0:0.000}", (-b) / (2 * a));
        }
        else
        {
            Console.WriteLine("The equation has no real roots.");
        }
    }
}