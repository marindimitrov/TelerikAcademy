//Write a program to calculate n! for each n in the range [1..100]. 
//Hint: Implement first a method that multiplies a number represented 
//as array of digits by given integer number.

using System;
using System.Linq;
using System.Numerics;

class NFactorialCalculating
{
    static void Main()
    {
        int[] nOfArray = new int[100];
        for (int i = 0; i < 100; i++)
        {
            nOfArray[i] = i + 1;
        }

        CalculateFactorial(nOfArray);
    }

    public static void CalculateFactorial(int[] nOfArray)
    {
        for (int i = 0; i < nOfArray.Length; i++)
        {
            BigInteger nFactorial = 1;
            while (nOfArray[i] > 0)
            {
                nFactorial *= nOfArray[i];
                nOfArray[i]--;
            }

            PrintFactorial(nFactorial);
        }
    }

    public static void PrintFactorial(BigInteger nFactorial)
    {
        Console.WriteLine(nFactorial);
    }
}