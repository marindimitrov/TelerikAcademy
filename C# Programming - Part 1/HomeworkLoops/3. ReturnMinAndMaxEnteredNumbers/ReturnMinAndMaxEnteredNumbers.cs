//Write a program that reads from the console a 
//sequence of N integer numbers and returns the 
//minimal and maximal of them.

using System;

class ReturnMinAndMaxEnteredNumbers
{
    static void Main()
    {
        Console.Write("Enter how many numbers you want to compare: ");
        int countNumbers = int.Parse(Console.ReadLine());
        int[] numbers = new int[countNumbers];

        for (int number = 0; number < countNumbers; number++)
        {
            Console.Write("Enter integer: ");
            numbers[number] = int.Parse(Console.ReadLine());
        }

        int maximalNumber = numbers[0];

        for (int number = 0; number < countNumbers; number++)
        {
            if (maximalNumber < numbers[number])
            {
                maximalNumber = numbers[number];
            }
        }
        Console.WriteLine("The maximal number is: {0}", maximalNumber);

        int minimalNumber = numbers[0];

        for (int number = 0; number < countNumbers; number++)
        {
            if (minimalNumber > numbers[number])
            {
                minimalNumber = numbers[number];
            }
        }
        Console.WriteLine("The minimal number is: {0}", minimalNumber);
    }
}