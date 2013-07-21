//Write a program to print the first 100 members of 
//the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 
//34, 55, 89, 144, 233, 377, …

using System;

class PrintSequenceOfFibonacci
{
    static void Main()
    {
        Console.WriteLine("In the list below are the first 100 members of Fibonacci's sequence:");
        ulong firstFibNum = 0;
        ulong secondFibNum = 1;
        Console.WriteLine("1 {0}", firstFibNum);
        Console.WriteLine("2 {0}", secondFibNum);
        for (int sequenceNumber = 3; sequenceNumber < 101; sequenceNumber++)
        {
            ulong fibNum = firstFibNum + secondFibNum;
            firstFibNum = secondFibNum;
            secondFibNum = fibNum;
            Console.WriteLine("{0} {1}", sequenceNumber, fibNum);
        }
    }
}