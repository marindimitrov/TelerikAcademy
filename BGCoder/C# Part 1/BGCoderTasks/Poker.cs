using System;

class Poker
{
    static void Main()
    {
        string[] a = new string[5];
        for (int i = 0; i < 5; i++)
        {
            a[i] = Console.ReadLine();
        }

        int[] b = new int[5];
        for (int i = 0; i < 5; i++)
        {
            if (a[i] == "2") { b[i] = 1; }
            if (a[i] == "3") { b[i] = 2; }
            if (a[i] == "4") { b[i] = 3; }
            if (a[i] == "5") { b[i] = 4; }
            if (a[i] == "6") { b[i] = 5; }
            if (a[i] == "7") { b[i] = 6; }
            if (a[i] == "8") { b[i] = 7; }
            if (a[i] == "9") { b[i] = 8; }
            if (a[i] == "10") { b[i] = 9; }
            if (a[i] == "J") { b[i] = 10; }
            if (a[i] == "Q") { b[i] = 11; }
            if (a[i] == "K") { b[i] = 12; }
            if (a[i] == "A") { b[i] = 13; }
        }

        if (b[0] == b[1] && b[0] == b[2] && b[0] == b[3] && b[0] == b[4])
        {
            Console.WriteLine("Impossible");
        }

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                for (int k = 0; k < 5; k++)
                {
                    for (int l = 0; l < 5; l++)
                    {
                        for (int m = 0; m < 5; m++)
                        {
                            if (b[i] < b[j] && b[j] < b[k] && b[k] < b[l] && b[l] < b[m])
                            {
                                Console.WriteLine("Straight");
                            }
                        }
                    }
                }
            }
        }

        decimal counter = 0.0m;
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (b[i] == b[j] && i != j)
                {
                    counter += 0.5m;
                }
            }
        }
        if (counter == 1)
        {
            Console.WriteLine("One Pair");
        }
        else if (counter == 2)
        {
            Console.WriteLine("Two Pairs");
        }

        decimal counterD = 0;
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                for (int k = 0; k < 5; k++)
                {
                    if (b[i] == b[j] && b[i] == b[k] && b[j] == b[k] && i != j && i != k && j != k)
                    {
                        counterD++;
                    }
                }
            }
        }
        if (counterD == 6)
        {
            Console.WriteLine("Three of a Kind");
        }

        decimal counterF = 0;
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                for (int k = 0; k < 5; k++)
                {
                    for (int l = 0; l < 5; l++)
                    {
                        if (b[i] == b[j] && b[i] == b[k] && b[j] == b[k] && b[i] == b[l] && i != j && i != k && j != k && i != l)
                        {
                            counterF++;
                        }
                    }
                }
            }
        }
        if (counterF == 72)
        {
            Console.WriteLine("Four of a Kind");
        }





    }
}