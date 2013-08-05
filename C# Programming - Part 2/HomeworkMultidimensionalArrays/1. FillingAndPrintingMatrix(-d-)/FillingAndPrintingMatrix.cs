//Write a program that fills and prints a matrix of size (n, n) as shown in examples for n = 4.

using System;

class FillingAndPrintingMatrix
{
    static void Main()
    {
        Console.Write("Enter N for spiral matrix: ");
        int n = int.Parse(Console.ReadLine());

        int[,] spiralMatrix = new int[n, n];

        FillingSpiralMatrix(spiralMatrix, n);

        PrintingMatrix(spiralMatrix, n);
    }

    public static void FillingSpiralMatrix(int[,] spiralMatrix, int n, int row = 0, int col = 0, string move = "down", int rightOffset = 0, int downOffset = 0, int leftOffset = 1, int upOffset = 0)
    {
        spiralMatrix[row, col] = 1;

        for (int i = 2; i <= n * n; i++)
        {
            if (col == leftOffset && move == "left")
            {
                move = "down";
                leftOffset++;
            }
            if (row == upOffset && move == "up")
            {
                move = "left";
                upOffset++;
            }
            if (col == n - 1 - rightOffset && move == "right")
            {
                move = "up";
                rightOffset++;
            }
            if (row == n - 1 - downOffset && move == "down")
            {
                move = "right";
                downOffset++;
            }

            if (move == "right")
            {
                col++;
                spiralMatrix[row, col] = i;
            }
            if (move == "down")
            {
                row++;
                spiralMatrix[row, col] = i;
            }
            if (move == "left")
            {
                col--;
                spiralMatrix[row, col] = i;
            }
            if (move == "up")
            {
                row--;
                spiralMatrix[row, col] = i;
            }
        }
    }

    public static void PrintingMatrix(int[,] spiralMatrix, int n)
    {
        Console.WriteLine("{0}", new string('-', 5 * n));
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < n; k++)
            {
                Console.Write("{0,3} |", spiralMatrix[j, k]);
            }
            Console.WriteLine();
            Console.WriteLine("{0}", new string('-', 5 * n));
        }
    }
}