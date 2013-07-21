//Write an expression that extracts from a given 
//integer i the value of a given bit number b. 
//Example: i=5; b=2  value=1.

using System;

class ExtractBitFromGivenInt
{
    static void Main()
    {
        Console.Write("Enter number and check its bit value on required position: ");
        int inputNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter a bit position, that you want to check: ");
        int position = int.Parse(Console.ReadLine());
        int mask = 1 << position;

        if (((mask & inputNumber) >> position) == 1)
        {
            Console.WriteLine("The bit on position {0} is \"1\"", position);
        }
        else
        {
            Console.WriteLine("The bit on position {0} is \"0\"", position);
        }
    }
}
