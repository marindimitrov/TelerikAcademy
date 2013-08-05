using System;

class FirTree
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        string[,] array = new string[n, (n - 2) * 2 + 1];

        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < (n - 2) * 2 + 1; col++)
            {
                array[row, col] = ".";
            }
        }

        for (int row = 0; row < n - 1; row++)
        {
            for (int col = n - 2 - row; col <= n - 2 + row; col++)
            {
                array[row, col] = "*";
            }
        }

        array[n - 1, n - 2] = "*";

        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < (n - 2) * 2 + 1; col++)
            {
                Console.Write(array[row, col]);
            }
            Console.WriteLine();
        }
    }
}