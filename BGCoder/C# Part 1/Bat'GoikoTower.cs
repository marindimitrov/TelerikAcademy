using System;

class BatGoikoTower
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        string[,] arr = new string[n, n * 2];

        for (int row = 0; row < arr.GetLength(0); row++)
        {
            for (int col = 0; col < arr.GetLength(1); col++)
            {
                arr[row, col] = ".";
            }
        }

        for (int row = 0; row < arr.GetLength(0); row++)
        {
            for (int col = n - 1 - row; col >= n - 1 - row; col--)
            {
                arr[row, col] = "/";
            }
        }

        for (int row = 0; row < arr.GetLength(0); row++)
        {
            for (int col = n + row; col <= n + row; col++)
            {
                arr[row, col] = "\\";
            }
        }

        for (int row = 0, step = 1; row < arr.GetLength(0); row = row + step, step++)
        {
            for (int col = n - row; col <= n - 1 + row; col++)
            {
                arr[row, col] = "-";
            }
        }

        for (int row = 0; row < arr.GetLength(0); row++)
        {
            for (int col = 0; col < arr.GetLength(1); col++)
            {
                Console.Write(arr[row, col]);
            }
            Console.WriteLine();
        }
    }
}