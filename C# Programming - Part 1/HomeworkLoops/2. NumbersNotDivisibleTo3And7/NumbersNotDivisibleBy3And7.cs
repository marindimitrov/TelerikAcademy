//Write a program that prints all the numbers from 1 to 
//N, that are not divisible by 3 and 7 at the same time.

using System;

class NumbersNotDivisibleBy3And7
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("The numbers from 1 to {0}, which are not divisible by 3 and 7 at the same time are: ", 
            number);
        for (int n = 1; n <= number; n++)
        {
            if (n % 3 != 0 && n % 7 != 0)
            {
                Console.Write("{0}, ", n);
            }
        }
    }
}