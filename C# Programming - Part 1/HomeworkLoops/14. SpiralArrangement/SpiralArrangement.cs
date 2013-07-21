//* Write a program that reads a positive integer 
//number N (N < 20) from console and outputs in the 
//console the numbers 1 ... N numbers arranged as a 
//spiral.
//      Example for N = 4
//       1  2  3 4
//      12 13 14 5
//      11 16 15 6
//      10  9  8 7

using System;

class SpiralArrangement
{
    static void Main()
    {
        Console.Write("Enter N for spiral matrix dimension: ");
        int n = int.Parse(Console.ReadLine());
        int[,] spiralMatrix = new int[n, n];

        int row = 0;
        int col = 0;
        string move = "right";
        int rightOffset = 0;
        int downOffset = 0;
        int leftOffset = 0;
        int upOffset = 1;

        spiralMatrix[row, col] = 1;

        for (int i = 2; i <= n * n; i++)
        {
            if (col == n - 1 - rightOffset && move == "right")
            {
                move = "down";
                rightOffset++;
            }
            if (row == n - 1 - downOffset && move == "down")
            {
                move = "left";
                downOffset++;
            }
            if (col == leftOffset && move == "left")
            {
                move = "up";
                leftOffset++;
            }
            if (row == upOffset && move == "up")
            {
                move = "right";
                upOffset++;
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

        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < n; k++)
            {
                Console.Write("{0:000} ", spiralMatrix[j, k]);
            }
            Console.WriteLine();
        }
    }
}