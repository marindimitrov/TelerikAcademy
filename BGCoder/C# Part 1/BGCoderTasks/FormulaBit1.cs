using System;

class FormulaBit1
{
    static void Main()
    {
        int n = 8;
        int[,] trackArray = new int[n, n];
        int input = 0;
        int sub = 0;

        for (int i = 0; i < n; i++)
        {
            input = int.Parse(Console.ReadLine());
            for (int j = 0; j < n; j++)
            {
                sub = input & (1 << (n - j - 1));
                if (sub != 0)
                {
                    trackArray[i, j] = 1;
                }
            }
        }

        int row = 0;
        int col = n - 1;
        trackArray[row, col] = trackArray[0, n - 1];

        string move = "down";
        int step = 1;
        int turn = 0;

        for (int i = 0; i < 64; i++)
        {
            if (row == n - 1 && col == 0)
            {
                Console.WriteLine("{0} {1}", step, turn);
                break;
            }
            if ((move == "down") && (row == n - 1))
            {
                move = "downLeft";
                turn++;
                if (trackArray[row, col - 1] == 1)
                {
                    Console.WriteLine("No {0}", step);
                    break;
                }
            }
            if ((move == "down") && (trackArray[row + 1, col] == 1))
            {
                move = "downLeft";
                turn++;
                if (col == 0)
                {
                    Console.WriteLine("No {0}", step);
                    break;
                }
                if (trackArray[row, col - 1] == 1)
                {
                    Console.WriteLine("No {0}", step);
                    break;
                }
            }
            else if ((move == "downLeft") && (col == 0))
            {
                move = "up";
                turn++;
                if (row == 0)
                {
                    Console.WriteLine("No {0}", step);
                    break;
                }
                if (trackArray[row - 1, col] == 1)
                {
                    Console.WriteLine("No {0}", step);
                    break;
                }
            }
            else if ((move == "downLeft") && (trackArray[row, col - 1] == 1))
            {
                move = "up";
                turn++;
                if (row == 0)
                {
                    Console.WriteLine("No {0}", step);
                    break;
                }
                if (trackArray[row - 1, col] == 1)
                {
                    Console.WriteLine("No {0}", step);
                    break;
                }
            }
            else if ((move == "up") && (row == 0))
            {
                move = "upLeft";
                turn++;
                if (col == 0)
                {
                    Console.WriteLine("No {0}", step);
                    break;
                }
                if (trackArray[row, col - 1] == 1)
                {
                    Console.WriteLine("No {0}", step);
                    break;
                }
            }
            else if ((move == "up") && (trackArray[row - 1, col] == 1))
            {
                move = "upLeft";
                turn++;
                if (col == 0)
                {
                    Console.WriteLine("No {0}", step);
                    break;
                }
                if (trackArray[row, col - 1] == 1)
                {
                    Console.WriteLine("No {0}", step);
                    break;
                }
            }
            else if ((move == "upLeft") && (col == 0))
            {
                move = "down";
                turn++;
                if (trackArray[row + 1, col] == 1)
                {
                    Console.WriteLine("No {0}", step);
                    break;
                }
            }
            else if ((move == "upLeft") && (trackArray[row, col - 1] == 1))
            {
                move = "down";
                turn++;
                if (row == n - 1)
                {
                    Console.WriteLine("No {0}", step);
                    break;
                }
                if (trackArray[row + 1, col] == 1)
                {
                    Console.WriteLine("No {0}", step);
                    break;
                }
            }

            if (move == "down")
            {
                trackArray[row, col] = 0;
                row++;
                step++;
            }
            else if (move == "downLeft")
            {
                trackArray[row, col] = 0;
                col--;
                step++;
            }
            else if (move == "up")
            {
                trackArray[row, col] = 0;
                row--;
                step++;
            }
            else if (move == "upLeft")
            {
                trackArray[row, col] = 0;
                col--;
                step++;
            }
        }
    }
}