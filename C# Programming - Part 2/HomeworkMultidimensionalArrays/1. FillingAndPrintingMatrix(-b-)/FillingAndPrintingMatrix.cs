//Write a program that fills and prints a matrix of size (n, n) as shown in examples for n = 4.

using System;

class FillingAndPrintingMatrix
{
    static void Main()
    {
        Console.Write("Enter N = ");
        int n = int.Parse(Console.ReadLine());

        int[,] matrix = new int[n, n];

        FillingMatrix(matrix, n);

        PrintingMatrix(matrix, n);
    }

    public static void FillingMatrix(int[,] matrix, int n, int row = 0, int col = 0, string move = "down")
    {                                                                //This method goes step by step to all matrix elements and fill them.
        matrix[0, 0] = 1;

        for (int i = 2; i <= n * n; i++)
        {
            if (move == "down" && row == n - 1)
            {
                move = "right";
                col++;
            }
            if (move == "right" && row == n - 1)
            {
                move = "up";
                matrix[row, col] = i;
                i++;
            }
            if (move == "up" && row == 0)
            {
                move = "right";
                col++;
            }
            if (move == "right" && row == 0)
            {
                move = "down";
                matrix[row, col] = i;
                i++;
            }

            if (move == "down")
            {
                row++;
                matrix[row, col] = i;
            }
            if (move == "right")
            {
                col++;
                matrix[row, col] = i;
            }
            if (move == "up")
            {
                row--;
                matrix[row, col] = i;
            }
        }
    }

    public static void PrintingMatrix(int[,] matrix, int n)         //Using this method to print the result matrix.
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("{0,2} ", matrix[i, j]);
            }
            Console.WriteLine();
        }
    }
}