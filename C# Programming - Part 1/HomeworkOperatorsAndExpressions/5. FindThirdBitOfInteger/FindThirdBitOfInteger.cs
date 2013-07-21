//Write a boolean expression for finding if the bit 3 
//(counting from 0) of a given integer is 1 or 0.

using System;

class FindThirdBitOfInteger
{
    static void Main()
    {
        Console.Write("Enter a number and check its third bit: ");
        int checkNum = int.Parse(Console.ReadLine());
        int compareNum = 4;
        Console.WriteLine((checkNum & compareNum) == 4 ? "The third bit is 1." : "The third bit is 0.");
    }
}
