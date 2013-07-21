//Write a boolean expression that returns if the bit at 
//position p (counting from 0) in a given integer 
//number v has value of 1. Example: v=5; p=1  false.

using System;

class CheckBitValueOnPosition
{
    static void Main()
    {
        Console.Write("Enter number and check its bit value on required position: ");
        int inputNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter a bit position, and check if it is \"1\": ");
        int position = int.Parse(Console.ReadLine());
        int mask = 1 << position;
        Console.Write("The bit on position {0} is \"1\" --> ", position);
        Console.WriteLine(((mask & inputNumber) >> position) == 1);
    }
}