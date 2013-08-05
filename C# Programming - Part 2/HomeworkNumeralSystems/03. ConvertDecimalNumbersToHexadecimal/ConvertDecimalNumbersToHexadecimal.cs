//Write a program to convert decimal numbers to their hexadecimal representation.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ConvertDecimalNumbersToHexadecimal
{
    static void Main()
    {
        Console.Write("Enter decimal number: ");
        int decimalNumber = int.Parse(Console.ReadLine());

        List<char> reversedHexadecimalRepresentationAsChar = new List<char>();

        ConvertToHex(decimalNumber, reversedHexadecimalRepresentationAsChar);

        PrintHex(reversedHexadecimalRepresentationAsChar);
    }

    public static void ConvertToHex(int decimalNumber, List<char> reversedHexadecimalRepresentationAsChar)
    {
        List<int> reversedHexadecimalRepresentationAsInt = new List<int>();

        int counter = 0;
        while (decimalNumber > 0)
        {
            reversedHexadecimalRepresentationAsInt.Add(decimalNumber % 16);

            switch (reversedHexadecimalRepresentationAsInt[counter])
            {
                case 0: reversedHexadecimalRepresentationAsChar.Add('0'); break;
                case 1: reversedHexadecimalRepresentationAsChar.Add('1'); break;
                case 2: reversedHexadecimalRepresentationAsChar.Add('2'); break;
                case 3: reversedHexadecimalRepresentationAsChar.Add('3'); break;
                case 4: reversedHexadecimalRepresentationAsChar.Add('4'); break;
                case 5: reversedHexadecimalRepresentationAsChar.Add('5'); break;
                case 6: reversedHexadecimalRepresentationAsChar.Add('6'); break;
                case 7: reversedHexadecimalRepresentationAsChar.Add('7'); break;
                case 8: reversedHexadecimalRepresentationAsChar.Add('8'); break;
                case 9: reversedHexadecimalRepresentationAsChar.Add('9'); break;
                case 10: reversedHexadecimalRepresentationAsChar.Add('A'); break;
                case 11: reversedHexadecimalRepresentationAsChar.Add('B'); break;
                case 12: reversedHexadecimalRepresentationAsChar.Add('C'); break;
                case 13: reversedHexadecimalRepresentationAsChar.Add('D'); break;
                case 14: reversedHexadecimalRepresentationAsChar.Add('E'); break;
                case 15: reversedHexadecimalRepresentationAsChar.Add('F'); break;
            }
            decimalNumber = decimalNumber / 16;
            counter++;
        }
    }

    public static void PrintHex(List<char> reversedHexadecimalRepresentationAsChar)
    {
        Console.Write("The corresponding hexadecimal number is: ");
        for (int i = reversedHexadecimalRepresentationAsChar.Count - 1; i >= 0; i--)
        {
            Console.Write(reversedHexadecimalRepresentationAsChar[i]);
        }
        Console.WriteLine();
    }
}