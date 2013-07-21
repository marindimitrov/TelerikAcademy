//Write a program that reads a number N and 
//calculates the sum of the first N members of the 
//sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 
//55, 89, 144, 233, 377, …
//Each member of the Fibonacci sequence (except the
//first two) is a sum of the previous two members.

using System;

class FibonacciFirstNMembers
{
    static void Main()
    {
        Console.WriteLine("Enter number N and calculate the first N members of Fibonacci's sequence:");
        int nMembers = int.Parse(Console.ReadLine());
        ulong firstFibNum = 0;
        ulong secondFibNum = 1;

        Console.WriteLine("\n1 {0}", firstFibNum);
        Console.WriteLine("2 {0}", secondFibNum);

        for (int sequenceNumber = 3; sequenceNumber <= nMembers; sequenceNumber++)
        {
            ulong fibNum = firstFibNum + secondFibNum;
            firstFibNum = secondFibNum;
            secondFibNum = fibNum;
            Console.WriteLine("{0} {1}", sequenceNumber, fibNum);
        }
    }
}