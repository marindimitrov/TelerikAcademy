//We are given integer number n, value v (v=0 or 1) 
//and a position p. Write a sequence of operators that 
//modifies n to hold the value v at the position p from 
//the binary representation of n.
//    Example: n = 5 (00000101), p=3, v=1  13 (00001101)
//    n = 5 (00000101), p=2, v=0  1 (00000001)

using System;

class ModifyIntByValueOfBit
{
    static void Main()
    {
        Console.Write("Enter number you want to change: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Enter bit position you want to change: ");
        int position = int.Parse(Console.ReadLine());
        Console.Write("Enter value of the {0} bit of number {1}: ", position, number);
        int bitValue = int.Parse(Console.ReadLine());
        int mask = 1 << position;

        if (bitValue == 1)
        {
            Console.WriteLine("The result number is: {0}", number | mask);
        }
        else if (bitValue == 0)
        {
            Console.WriteLine("The result number is: {0}", number & (~ mask));
        }
        else
        {
            Console.WriteLine("Wrong bit value, please enter \"0\" or \"1\".");
        }
    }
}