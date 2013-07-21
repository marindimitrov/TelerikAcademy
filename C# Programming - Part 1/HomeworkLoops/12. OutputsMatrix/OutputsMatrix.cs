//Write a program that reads from the console a 
//positive integer number N (N < 20) and outputs 
//a matrix like the following:
//  N = 3        N = 4
//  1 2 3        1 2 3 4
//  2 3 4        2 3 4 5
//  3 4 5        3 4 5 6
//               4 5 6 7

using System;

class OutputsMatrix
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        if (n < 20)
        {
            int firstCol = 0;
            for (int row = 1; row <= n; row++)
            {
                firstCol++;
                for (int col = firstCol; col <= n + firstCol - 1; col++)
                {
                    Console.Write("{0,2} ", col);
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Please enter N < 20.");
        }
    }
}