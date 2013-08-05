using System;

class UKFlag
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        string[,] arr = new string[n, n];

        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                arr[row, col] = ".";
            }
        }

        for (int row = 0; row < n; row++)
        {
            for (int col = n / 2; col <= n / 2; col++)
            {
                arr[row, col] = "|";
            }
        }

        for (int row = 0; row < n; row++)
        {
            for (int col = row; col <= row; col++)
            {
                arr[row, col] = "\\";
            }
        }

        for (int row = 0; row < n; row++)
        {
            for (int col = n - 1 - row; col >= n - 1 - row; col--)
            {
                arr[row, col] = "/";
            }
        }

        for (int row = n / 2; row <= n / 2; row++)
        {
            for (int col = 0; col < n; col++)
            {
                arr[row, col] = "-";
            }
        }

        arr[n / 2, n / 2] = "*";

        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                Console.Write(arr[row, col]);
            }
            Console.WriteLine();
        }
    }
}