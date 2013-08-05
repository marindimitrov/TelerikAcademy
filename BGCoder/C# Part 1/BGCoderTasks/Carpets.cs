using System;

class Carpets
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        string[,] array = new string[n, n];

        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                array[row, col] = " ";
            }
        }

        for (int row = 0; row < n / 2; row++)
        {
            for (int col = n / 2 - 1 - row; col < n / 2; col += 2)
            {
                array[row, col] = "/";
            }
        }
        for (int row = 0; row < n / 2; row++)
        {
            for (int col = n / 2 + row; col > n / 2 - 1; col -= 2)
            {
                array[row, col] = "\\";
            }
        }
        for (int row = n / 2; row < n; row++)
        {
            for (int col = row - n / 2; col < n / 2; col += 2)
            {
                array[row, col] = "\\";
            }
        }
        for (int row = n / 2; row < n; row++)
        {
            for (int col = n - 1 - row + n / 2; col > n / 2 - 1; col -= 2)
            {
                array[row, col] = "/";
            }
        }

        for (int row = 0; row < n / 2 - 1; row++)
        {
            for (int col = 0; col < n / 2 - 1 - row; col++)
            {
                array[row, col] = ".";
            }
        }
        for (int row = 0; row < n / 2 - 1; row++)
        {
            for (int col = n / 2 + 1 + row; col < n; col++)
            {
                array[row, col] = ".";
            }
        }
        for (int row = n / 2 + 1; row < n; row++)
        {
            for (int col = 0; col < row - n / 2; col++)
            {
                array[row, col] = ".";
            }
        }
        for (int row = n / 2 + 1; row < n; row++)
        {
            for (int col = n - row + n / 2; col < n; col++)
            {
                array[row, col] = ".";
            }
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(array[i, j]);
            }
            Console.WriteLine();
        }
    }
}