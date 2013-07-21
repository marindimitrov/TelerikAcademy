//Write a program that calculates N!/K! for given N and K (1<K<N).

using System;
using System.Numerics;

class CalculateNFactorialDividedByKFactorial
{
    static void Main()
    {
        Console.WriteLine("This program calculates N!/K! for given N and K (1<K<N).");
        Console.Write("Enter N: ");
        BigInteger n = BigInteger.Parse(Console.ReadLine());
        Console.Write("Enter K: ");
        BigInteger k = BigInteger.Parse(Console.ReadLine());

        if (1 < k && k < n)
        {
            BigInteger nFactorial = 1;
            while (n > 0)
            {
                nFactorial *= n;
                n--;
            }
            BigInteger kFactorial = 1;
            while (k > 0)
            {
                kFactorial *= k;
                k--;
            }
            Console.WriteLine("N!/K! = " + nFactorial / kFactorial);
        }
        else
        {
            Console.WriteLine("Check the condition 1 < K < N !!!");
            return;
        }
    }
}