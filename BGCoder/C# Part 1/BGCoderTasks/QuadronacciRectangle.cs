using System;

class QuadronacciRectangle
{
    static void Main()
    {
        long firstQuad = long.Parse(Console.ReadLine());
        long secondQuad = long.Parse(Console.ReadLine());
        long thirdQuad = long.Parse(Console.ReadLine());
        long fourthQuad = long.Parse(Console.ReadLine());

        long nextQuad = 0;

        int rows = int.Parse(Console.ReadLine());
        int cols = int.Parse(Console.ReadLine());

        Console.Write(" {0}", firstQuad);
        Console.Write(" {0}", secondQuad);
        Console.Write(" {0}", thirdQuad);
        Console.Write(" {0}", fourthQuad);

        for (int col = 5; col <= cols; col++)
        {
            nextQuad = firstQuad + secondQuad + thirdQuad + fourthQuad;
            firstQuad = secondQuad;
            secondQuad = thirdQuad;
            thirdQuad = fourthQuad;
            fourthQuad = nextQuad;

            Console.Write(" {0}", nextQuad);
        }

        Console.WriteLine();

        for (int row = 2; row <= rows; row++)
        {
            for (int col = 1; col <= cols; col++)
            {
                nextQuad = firstQuad + secondQuad + thirdQuad + fourthQuad;
                firstQuad = secondQuad;
                secondQuad = thirdQuad;
                thirdQuad = fourthQuad;
                fourthQuad = nextQuad;

                Console.Write(" {0}", nextQuad);
            }
            Console.WriteLine();
        }
    }
}