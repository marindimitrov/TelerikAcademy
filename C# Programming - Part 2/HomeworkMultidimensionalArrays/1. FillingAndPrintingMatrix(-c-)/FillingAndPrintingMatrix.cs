//Write a program that fills and prints a matrix of size (n, n) as shown in examples for n = 4.

using System;

class FillingAndPrintingMatrix
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[,] array = new int[n, n];

        FillArray(array);

        PrintArray(array);
    }

    public static void FillArray(int[,] array)
    {
        int number = 1;

        int startRow = 0;
        int startCol = 0;

        for (startRow = array.GetLength(0) - 1; startRow >= 0; startRow--)
        {
            for (int row = startRow, col = startCol; row < array.GetLength(0); row++, col++)
            {
                array[row, col] = number;
                number++;
            }
        }

        startRow = 0;
        startCol = 0;

        for (startCol = 1; startCol < array.GetLength(1); startCol++)
        {
            for (int row = startRow, col = startCol; col < array.GetLength(1); row++, col++)
            {
                array[row, col] = number;
                number++;
            }
        }
    }

    public static void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write("{0,2} ", array[i, j]);
            }
            Console.WriteLine();
        }
    }
}