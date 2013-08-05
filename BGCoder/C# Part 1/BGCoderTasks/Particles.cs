using System;

class Particles
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[,] x = new int[2, n];
        int[,] y = new int[2, n];

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < n; j++)
            {
                x[i, j] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
        }

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < n; j++)
            {
                y[i, j] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
        }

        int energy = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (y[0, j]/x[1, i] == x[0, i]/y[1,j])
                {
                    energy++;
                }
            }
        }
        Console.WriteLine(energy);
    }
}