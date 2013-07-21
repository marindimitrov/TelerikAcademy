//Write a program that prints all the numbers from 1 to N.

using System;

class PrintNumbersFromOneToN
{
    static void Main()
    {
        Console.WriteLine("Please enter number and the program will print all numbers from 1 to that number.");
        int number = int.Parse(Console.ReadLine());
        Console.Write("The numbers from 1 to {0} are: ", number);
        for (int printN = 1; printN <= number; printN++)
        {
            Console.Write("{0}, ", printN);
        }
    }
}