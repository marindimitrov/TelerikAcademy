//Write a program that finds the biggest of three 
//integers using nested if statements.

using System;

class FindsBiggestOfThreeIntegers
{
    static void Main()
    {
        Console.WriteLine("Enter three integers: ");
        int firstInt = int.Parse(Console.ReadLine());
        int secondInt = int.Parse(Console.ReadLine());
        int thirdInt = int.Parse(Console.ReadLine());

        if (firstInt >= secondInt)
        {
            if (firstInt >= thirdInt)
            {
                Console.WriteLine("The biggest integer is: {0}", firstInt);
            }
            else
            {
                Console.WriteLine("The biggest integer is: {0}", thirdInt);
            }
        }
        else if (secondInt >= firstInt)
        {
            if (secondInt >= thirdInt)
            {
                Console.WriteLine("The biggest integer is: {0}", secondInt);
            }
            else
            {
                Console.WriteLine("The biggest integer is: {0}", thirdInt);
            }
        }
    }
}