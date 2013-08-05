using System;

class TripleRotationOfDigits
{
    static void Main()
    {
        int k = int.Parse(Console.ReadLine());
        int remainder = 0;

        int kSub = k;
        int symbolCounter = 0;
        while (kSub / 10 >= 10)
        {
            kSub = kSub / 10;
            symbolCounter++;
        }
        symbolCounter += 2;

        for (int i = 0; i < 3; i++)
        {
            remainder = k % 10;
            k = k / 10;
            if (remainder == 0)
            {
                continue;
            }
            else
            {
                k = k + (remainder * (int)Math.Pow(10, symbolCounter - 1));
            }
        }
        Console.WriteLine(k);
    }
}