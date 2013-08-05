//Write a program that reads a rectangular matrix of size N x M and 
//finds in it the square 3 x 3 that has maximal sum of its elements.

using System;

class MaximalSumOfSubMatrix
{
    static int n;
    static int m;
    static int biggestSumStartRow;
    static int biggestSumStartCol;
    static int currentSum;
    static int biggestSum;

    static void Main()
    {
        Console.Write("Enter matrix rows: ");
        n = int.Parse(Console.ReadLine());
        Console.Write("Enter matrix columns: ");
        m = int.Parse(Console.ReadLine());

        int[,] inputMatrix = new int[n, m];

        EnteringInputMatrix(inputMatrix);

        Console.WriteLine("\nOur input matrix is: ");
        PrintMatrix(inputMatrix, 0, n, 0, m);

        FindingMaxSumSubsetMatrix(inputMatrix);

        Console.WriteLine("\nThe maximal inner matrix 3x3 is:");
        PrintMatrix(inputMatrix, biggestSumStartRow, biggestSumStartRow + 3, biggestSumStartCol, biggestSumStartCol + 3);
    }

    public static void EnteringInputMatrix(int[,] matrix)
    {
        Console.WriteLine("Enter matrix elements, as follows:");
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("Element [{0}, {1}] = ", row, col);
                matrix[row, col] = int.Parse(Console.ReadLine());
            }
        }
    }

    public static void FindingMaxSumSubsetMatrix(int[,] matrix)
    {
        for (int row = 0; row < n - 2; row++)
        {
            for (int col = 0; col < m - 2; col++)
            {
                for (int i = row; i <= row + 2; i++)
                {
                    for (int j = col; j <= col + 2; j++)
                    {
                        currentSum += matrix[i, j];
                    }
                }
                if (currentSum > biggestSum)
                {
                    biggestSum = currentSum;
                    biggestSumStartRow = row;
                    biggestSumStartCol = col;
                }
                currentSum = 0;
            }
        }
    }

    public static void PrintMatrix(int[,] matrix, int rowStart, int rowEnd, int colStart, int colEnd)
    {
        for (int row = rowStart; row < rowEnd; row++)
        {
            for (int col = colStart; col < colEnd; col++)
            {
                Console.Write("{0,2} ", matrix[row, col]);
            }
            Console.WriteLine();
        }
    }
}