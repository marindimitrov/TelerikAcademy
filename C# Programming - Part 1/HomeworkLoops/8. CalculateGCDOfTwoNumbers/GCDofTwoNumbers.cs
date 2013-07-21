//Write a program that calculates the greatest 
//common divisor (GCD) of given two numbers. Use 
//the Euclidean algorithm (find it in Internet).

using System;

class GCDofTwoNumbers
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        int iMax = 0;
        if (a > b)
        {
            for (int i = 1; i <= b; i++)
            {
                if (a % i == 0 && b % i == 0)
                {
                    iMax = i;
                }
            }
        }
        else
        {
            for (int j = 1; j <= a; j++)
            {
                if (a % j == 0 && b % j == 0)
                {
                    iMax = j;
                }
            }
        }
        Console.WriteLine(iMax);
    }
}