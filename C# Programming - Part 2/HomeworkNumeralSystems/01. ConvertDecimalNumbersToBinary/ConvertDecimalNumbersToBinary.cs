//Write a program to convert decimal numbers to their binary representation.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ConvertDecimalNumbersToBinary
{
    static void Main()
    {
        Console.Write("Enter decimal number: ");
        int decimalNumber = int.Parse(Console.ReadLine());

        List<int> reversedBinaryRepresentation = new List<int>();

        while (decimalNumber > 0)
        {
            reversedBinaryRepresentation.Add(decimalNumber % 2);
            decimalNumber = decimalNumber / 2;
        }

        Console.Write("The corresponding binary number is: ");
        for (int i = reversedBinaryRepresentation.Count - 1; i >= 0; i--)
        {
            Console.Write(reversedBinaryRepresentation[i]);
        }
        Console.WriteLine();
    }
}