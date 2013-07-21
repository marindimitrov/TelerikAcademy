//In the combinatorial mathematics, the Catalan numbers are calculated 
//by the following formula: Cn = (2n)!/((n+1)!*n!)
//Write a program to calculate the Nth Catalan number by given N.

using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
        Console.Write("Enter n to calculate the n-th Catalan number: ");
        BigInteger n = BigInteger.Parse(Console.ReadLine());
        BigInteger firstMember = 2 * n;
        BigInteger secondMember = n + 1;
        BigInteger thirdMember = n;

        if (n >= 0)
        {
            BigInteger firstFactorial = 1;
            while (firstMember > 0)
            {
                firstFactorial *= firstMember;
                firstMember--;
            }
            BigInteger secondFactorial = 1;
            while (secondMember > 0)
            {
                secondFactorial *= secondMember;
                secondMember--;
            }
            BigInteger thirdFactorial = 1;
            while (thirdMember > 0)
            {
                thirdFactorial *= thirdMember;
                thirdMember--;
            }
            Console.WriteLine("The {0}-th Catalan number is {1}", 
                             n, firstFactorial / (secondFactorial * thirdFactorial));
        }
        else
        {
            Console.WriteLine("Check the condition n >= 0");
        }
    }
}