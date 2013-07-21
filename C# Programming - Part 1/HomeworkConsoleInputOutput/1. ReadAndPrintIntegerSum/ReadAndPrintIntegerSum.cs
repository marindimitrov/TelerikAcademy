//Write a program that reads 3 integer numbers from 
//the console and prints their sum.

using System;

class ReadAndPrintIntegerSum
{
    static void Main()
    {
        Console.Write("Enter first integer: ");
        int firstInt = int.Parse(Console.ReadLine());
        Console.Write("Enter second integer: ");
        int secondInt = int.Parse(Console.ReadLine());
        Console.Write("Enter third integer: ");
        int thirdInt = int.Parse(Console.ReadLine());
        Console.WriteLine("The sum of the three integers is: {0} \n", 
            firstInt + secondInt + thirdInt);
    }
}

