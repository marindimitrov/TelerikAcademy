//Write a program that, for a given two integer 
//numbers N and X, calculates the sum
//S = 1 + 1!/X + 2!/X^2 + … + N!/X^N

using System;
using System.Numerics;

class CalculateSumForNAndX
{
    static void Main()
    {
        Console.WriteLine("This program calculates S = 1 + 1!/X + 2!/X^2 + … + N!/X^N for given N and X.");
        Console.Write("Enter N: ");
        double n = double.Parse(Console.ReadLine());
        Console.Write("Enter X: ");
        double x = double.Parse(Console.ReadLine());

        double sum = 1;
        double nMember = 0;

        for (double i = 1; i <= n; i++)
        {
            double nFactorial = 1;
            double k = i;

            while (k > 0)
            {
                nFactorial *= k;
                k--;
            }

            double denominator = Math.Pow(x, i);
            nMember = nFactorial / denominator;
            sum += nMember;
        }
        Console.WriteLine("The result is: {0:0.0000}", sum);
    }
}