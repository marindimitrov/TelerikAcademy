using System;

class TribonacciTriangle
{
    static void Main()
    {
        long firstTrib = long.Parse(Console.ReadLine());
        long secondTrib = long.Parse(Console.ReadLine());
        long thirdTrib = long.Parse(Console.ReadLine());
        long nextTrib = 0;

        int l = int.Parse(Console.ReadLine());

        Console.WriteLine(firstTrib);
        Console.WriteLine(secondTrib + " " + thirdTrib);

        for (int row = 2; row < l; row++)
        {
            for (int col = 0; col <= row; col++)
            {
                nextTrib = firstTrib + secondTrib + thirdTrib;
                firstTrib = secondTrib;
                secondTrib = thirdTrib;
                thirdTrib = nextTrib;
               
                Console.Write("{0} ", nextTrib);
            }
            Console.WriteLine();
        }
    }
}