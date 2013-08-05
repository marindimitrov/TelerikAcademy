using System;

class Pillars
{
    static void Main()
    {
        int[,] array = new int[8, 8];

        for (int i = 0; i < 8; i++)
        {
            int n = int.Parse(Console.ReadLine());
            for (int j = 0; j < 8; j++)
            {
                array[i, j] = (n & (1 << j)) / (1 << j);
            }
        }

        int[] sums = new int[8];

        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                sums[i] += array[j, i];
            }
        }

        if (sums[0] + sums[1] + sums[2] + sums[3] + sums[4] + sums[5] == sums[7])
        {
            Console.WriteLine("6");
            Console.WriteLine(sums[7]);
        }
        else if (sums[0] + sums[1] + sums[2] + sums[3] + sums[4] == sums[6] + sums[7])
        {
            Console.WriteLine("5");
            Console.WriteLine(sums[6] + sums[7]);
        }
        else if (sums[0] + sums[1] + sums[2] + sums[3] == sums[5] + sums[6] + sums[7])
        {
            Console.WriteLine("4");
            Console.WriteLine(sums[5] + sums[6] + sums[7]);
        }
        else if (sums[0] + sums[1] + sums[2] == sums[4] + sums[5] + sums[6] + sums[7])
        {
            Console.WriteLine("3");
            Console.WriteLine(sums[0] + sums[1] + sums[2]);
        }
        else if (sums[0] + sums[1] == sums[3] + sums[4] + sums[5] + sums[6] + sums[7])
        {
            Console.WriteLine("2");
            Console.WriteLine(sums[0] + sums[1]);
        }
        else if (sums[0] == sums[2] + sums[3] + sums[4] + sums[5] + sums[6] + sums[7])
        {
            Console.WriteLine("1");
            Console.WriteLine(sums[0]);
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}