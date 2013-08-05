//Write a program to convert binary numbers to their decimal representation.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ConvertBinaryNumbersToDecimal
{
    static void Main()
    {
        Console.Write("Enter binary number: ");
        long binaryNumber = long.Parse(Console.ReadLine());

        string binaryNumberAsString = binaryNumber.ToString();

        int decimalNumber = 0;
        for (int i = binaryNumberAsString.Length - 1, j = 0; i >= 0; i--, j++)
        {
            decimalNumber = decimalNumber + (((int)binaryNumberAsString[i] - 48) * (int)Math.Pow(2, j));
        }

        Console.WriteLine("The corresponding decimal number is: {0}", decimalNumber);
    }
}