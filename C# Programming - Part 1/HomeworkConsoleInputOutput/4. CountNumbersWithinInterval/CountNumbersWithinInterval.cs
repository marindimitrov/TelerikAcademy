//Write a program that reads two positive integer 
//numbers and prints how many numbers p exist 
//between them such that the reminder of the division 
//by 5 is 0 (inclusive). Example: p(17,25) = 2.

using System;

class CountNumbersWithinInterval
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        uint firstInteger = uint.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        uint secondInteger = uint.Parse(Console.ReadLine());

        uint counter = 0;
        for (uint i = firstInteger; i <= secondInteger; i++)
        {
            if (i % 5 == 0)
            {
                counter++;
            }
        }
        Console.WriteLine("The number of integers, which can be divided by 5 without remainder is: {0}", counter);
    }
}