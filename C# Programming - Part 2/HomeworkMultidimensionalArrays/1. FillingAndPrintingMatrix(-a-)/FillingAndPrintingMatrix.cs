//Write a program that fills and prints a matrix of size (n, n) as shown in examples for n = 4.

using System;

class FillingAndPrintingMatrix
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());

        int[,] arrayMatrix = new int[n, n];

        FillArray(arrayMatrix, 1);

        PrintArray(arrayMatrix);
    }

    public static void FillArray(int[,] arrayToFill, int filling)
    {
        for (int col = 0; col < arrayToFill.GetLength(1); col++)
        {
            for (int row = 0; row < arrayToFill.GetLength(0); row++)
            {
                arrayToFill[row, col] = filling;
                filling++;
            }
        }
    }

    public static void PrintArray(int[,] arrayToPrint)
    {
        for (int row = 0; row < arrayToPrint.GetLength(0); row++)
        {
            for (int col = 0; col < arrayToPrint.GetLength(1); col++)
            {
                Console.Write("{0,2} ", arrayToPrint[row, col]);
            }
            Console.WriteLine();
        }
    }
}