//Write an expression that checks if given positive 
//integer number n (n ≤ 100) is prime. E.g. 37 is prime.

using System;

class PrimeNumbers1to100
{
    static void Main()
    {
        for (int x = 1; x <= 100; x++)
        {
            for (int y = 1; y <= 100; y++)
            {
                if (x != y)
                {
                    if ((x % y) == 0)
                    {
                        Console.WriteLine("The number {0} is not prime.", x);
                    }
                    else
                    {
                        Console.WriteLine("The number {0} is prime.", x);
                    }
                }
                else
                {
                    Console.WriteLine(".");
                }
            }
        }
    }
}
