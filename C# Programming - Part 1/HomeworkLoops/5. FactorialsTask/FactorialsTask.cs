//Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K).

using System;
using System.Numerics;

class FactorialsTask
{
    static void Main()
    {
        Console.WriteLine("This program calculates N!*K! / (K-N)! for given N and K (1<K<N).");
        Console.Write("Enter N: ");
        BigInteger n = BigInteger.Parse(Console.ReadLine());
        Console.Write("Enter K: ");
        BigInteger k = BigInteger.Parse(Console.ReadLine());
        BigInteger kn = n - k;

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
            BigInteger knFactorial = 1;
            while (kn > 0)
            {
                knFactorial *= kn;
                kn--;
            }
            Console.WriteLine("N!*K! / (K-N)! = {0}", (nFactorial * kFactorial)/(-(knFactorial)));
        }
        else
        {
            Console.WriteLine("Check the condition 1 < K < N !!!");
        }
    }
}