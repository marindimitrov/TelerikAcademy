//Write a program to convert hexadecimal numbers to their decimal representation.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ConvertHexadecimalNumbersToDecimal
{
    static void Main()
    {
        Console.Write("Enter hexadecimal number: ");

        string input = Console.ReadLine();

        List<char> hexadecimalNumber = new List<char>();

        for (int i = input.Length - 1; i >= 0; i--)
        {
            hexadecimalNumber.Add(input[i]);
        }
        
        int decimalNumber = 0;

        for (int i = 0; i < hexadecimalNumber.Count; i++)
        {
            if (hexadecimalNumber[i] == 'A' || hexadecimalNumber[i] == 'B' || hexadecimalNumber[i] == 'C' ||
                     hexadecimalNumber[i] == 'D' || hexadecimalNumber[i] == 'E' || hexadecimalNumber[i] == 'F')
            {
                decimalNumber = decimalNumber + ((hexadecimalNumber[i] - 55) * (int)Math.Pow(16, i));
            }
            else
            {
                decimalNumber = decimalNumber + ((hexadecimalNumber[i] - 48) * (int)Math.Pow(16, i));
            }
        }

        Console.WriteLine("The corresponding decimal number is: {0}", decimalNumber);
    }
}