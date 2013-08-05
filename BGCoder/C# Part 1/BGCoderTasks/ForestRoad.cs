using System;

class ForestRoad
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        string[,] mapArray = new string[2 * n - 1, n];

        for (int i = 0; i < 2 * n - 1; i++)
        {
            for (int j = 0; j < n; j++)
            {
                mapArray[i, j] = ".";
            }
        }

        int row = 0;
        int col = 0;
        string move = "lowRight";

        mapArray[row, col] = "*";

        for (int i = 0; i < 2 * n - 2; i++)
        {
            if (col == n - 1)
            {
                move = "lowLeft";
            }

            if (move == "lowRight")
            {
                row++;
                col++;
                mapArray[row, col] = "*";
            }
            if (move == "lowLeft")
            {
                row++;
                col--;
                mapArray[row, col] = "*";
            }
        }

        for (int i = 0; i < 2 * n - 1; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(mapArray[i, j]);
            }
            Console.WriteLine();
        }
    }
}