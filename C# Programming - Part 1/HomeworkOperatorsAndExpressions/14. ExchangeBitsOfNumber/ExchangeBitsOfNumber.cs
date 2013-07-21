//* Write a program that exchanges bits {p, p+1, …, 
//p+k-1) with bits {q, q+1, …, q+k-1} of given 32-bit 
//unsigned integer.

using System;

class ExchangeBitsOnUnsignedInteger
{
    static void Main()
    {
        Console.Write("Enter number you want to change: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Enter p-bit position, which it will start exchange: ");
        int startP = int.Parse(Console.ReadLine());
        Console.Write("Enter number of bits you want to exchange: ");
        int numberOfBits = int.Parse(Console.ReadLine());
        Console.Write("Enter how many bit positions q-bit is shifted from p-bit: ");
        int m = int.Parse(Console.ReadLine());

        for (int p = startP; p < startP + numberOfBits; p++)
        {
            int maskP = 1 << p;
            int bitP = ((number & maskP) == Math.Pow(2, p)) ? 1 : 0;
            int bitQChanged = bitP;

            int q = p + m;
            int maskQ = 1 << q;
            int bitQ = ((number & maskP) == Math.Pow(2, q)) ? 1 : 0;
            int bitPChanged = bitQ;

            if (bitQChanged == 1)
            {
                number = number | maskQ;
            }
            else if (bitQChanged == 0)
            {
                number = number & (~maskQ);
            }

            if (bitPChanged == 1)
            {
                number = number | maskP;
            }
            else if (bitPChanged == 0)
            {
                number = number & (~maskP);
            }
        }
        Console.WriteLine("The changed new number is: {0}", number);
    }
}