using System;

class Fire
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        string[,] arr = new string[n + n / 4 + 1, n];

        for (int row = 0; row < arr.GetLength(0); row++)
        {
            for (int col = 0; col < n; col++)
            {
                arr[row, col] = ".";
            }
        }

        for (int row = 0; row < n / 2; row++)
        {
            for (int col = n / 2 - 1 - row; col >= n / 2 - 1 - row; col--)
            {
                arr[row, col] = "#";
            }
        }

        for (int row = 0; row < n / 2; row++)
        {
            for (int col = arr.GetLength(1) / 2 + row; col <= arr.GetLength(1) / 2 + row; col++)
            {
                arr[row, col] = "#";
            }
        }

        for (int row = n / 2; row < (n / 2 + n / 4); row++)
        {
            for (int col = 0 + row - n / 2; col <= 0 + row - n / 2; col++)
            {
                arr[row, col] = "#";
            }
        }

        for (int row = n / 2; row < (n / 2 + n / 4); row++)
        {
            for (int col = n - 1 - (row - n / 2); col >= n - 1 - (row - n / 2); col--)
            {
                arr[row, col] = "#";
            }
        }

        for (int col = 0; col < n; col++)
        {
            arr[n / 2 + n / 4, col] = "-";
        }

        for (int row = n / 2 + n / 4 + 1; row < n + n / 4 + 1; row++)
        {
            for (int col = 0 + (row - (n / 2 + n / 4 + 1)); col < n / 2; col++)
            {
                arr[row, col] = "\\";
            }
        }

        for (int row = n / 2 + n / 4 + 1; row < n + n / 4 + 1; row++)
        {
            for (int col = n / 2; col < n - (row - (n / 2 + n / 4 + 1)); col++)
            {
                arr[row, col] = "/";
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