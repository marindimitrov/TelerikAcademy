using System;

class Trapezoid
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        string[,] arr = new string[n + 1, n * 2];

        for (int row = 0; row < n + 1; row++)
        {
            for (int col = 0; col < n * 2; col++)
            {
                arr[row, col] = ".";
            }
        }

        for (int col = n; col < n * 2; col++)
        {
            arr[0, col] = "*";
        }

        for (int row = 0; row < n + 1; row++)
        {
            for (int col = n - row; col >= n - row; col--)
            {
                arr[row, col] = "*";
            }
        }

        for (int row = 0; row < n + 1; row++)
        {
            for (int col = 2 * n - 1; col < 2 * n; col++)
            {
                arr[row, col] = "*";
            }
        }

        for (int col = 0; col < n * 2; col++)
        {
            arr[n, col] = "*";
        }

        for (int row = 0; row < n + 1; row++)
        {
            for (int col = 0; col < n * 2; col++)
            {
                Console.Write(arr[row, col]);
            }
            Console.WriteLine();
        }
    }
}