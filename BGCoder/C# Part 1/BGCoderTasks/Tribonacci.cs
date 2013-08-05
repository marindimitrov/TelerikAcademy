using System;
using System.Numerics;

class Tribonacci
{
    static void Main()
    {
        BigInteger firstTrib = BigInteger.Parse(Console.ReadLine());
        BigInteger secondTrib = BigInteger.Parse(Console.ReadLine());
        BigInteger thirdTrib = BigInteger.Parse(Console.ReadLine());

        int n = int.Parse(Console.ReadLine());

        BigInteger nextTrib = 0;

        if (n > 3)
        {
            for (int i = 4; i <= n; i++)
            {
                nextTrib = firstTrib + secondTrib + thirdTrib;
                firstTrib = secondTrib;
                secondTrib = thirdTrib;
                thirdTrib = nextTrib;
            }
            Console.WriteLine(nextTrib);
        }
        else if (n == 1)
        {
            Console.WriteLine(firstTrib);
        }
        else if (n == 2)
        {
            Console.WriteLine(secondTrib);
        }
        else if (n == 3)
        {
            Console.WriteLine(thirdTrib);
        }
    }
}