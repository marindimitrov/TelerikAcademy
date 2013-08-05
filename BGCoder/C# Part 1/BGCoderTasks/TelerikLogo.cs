using System;

class TelerikLogo
{
    static void Main()
    {
        int x = int.Parse(Console.ReadLine());
        int n = ((x - 2) * 3) + 4;
        string[,] logoArray = new string[n, n];
        int totalSymbols = 7 * x - 6;
        if (x % 2 != 0 && x >= 3 && x <= 20)
        {
            for (int p = 0; p < n; p++)
            {
                for (int q = 0; q < n; q++)
                {
                    logoArray[p, q] = ".";
                }
            }

            int row = x / 2;
            int col = 0;
            string move = "leftZ";

            logoArray[row, col] = "*";

            for (int i = 2; i <= totalSymbols; i++)
            {
                if (row == 0 && move == "leftZ")
                {
                    move = "leftY";
                }
                if (col == n - x / 2 - 1 && move == "leftY")
                {
                    move = "rightX";
                }
                if (row == (n - 1) && move == "rightX")
                {
                    move = "leftX";
                }
                if (col == x / 2 && move == "leftX")
                {
                    move = "rightY";
                }
                if (row == 0 && move == "rightY")
                {
                    move = "rightZ";
                }

                if (move == "leftZ")
                {
                    row--;
                    col++;
                    logoArray[row, col] = "*";
                }
                if (move == "leftY")
                {
                    row++;
                    col++;
                    logoArray[row, col] = "*";
                }
                if (move == "rightX")
                {
                    row++;
                    col--;
                    logoArray[row, col] = "*";
                }
                if (move == "leftX")
                {
                    row--;
                    col--;
                    logoArray[row, col] = "*";
                }
                if (move == "rightY")
                {
                    row--;
                    col++;
                    logoArray[row, col] = "*";
                }
                if (move == "rightZ")
                {
                    row++;
                    col++;
                    logoArray[row, col] = "*";
                }
            }

            for (int p = 0; p < n; p++)
            {
                for (int q = 0; q < n; q++)
                {
                    Console.Write("{0}", logoArray[p, q]);
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("X is not appropriate.");
        }
    }
}