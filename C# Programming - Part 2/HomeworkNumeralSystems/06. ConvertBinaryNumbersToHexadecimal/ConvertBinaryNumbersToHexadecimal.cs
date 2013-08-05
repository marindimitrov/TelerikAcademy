//Write a program to convert binary numbers to hexadecimal numbers (directly).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ConvertBinaryNumbersToHexadecimal
{
    static void Main()
    {
        string binaryNumberAsString = Console.ReadLine();

        List<int> reversedBinaryNumberAsList = new List<int>();

        for (int i = binaryNumberAsString.Length - 1; i >= 0; i--)
        {
            reversedBinaryNumberAsList.Add(binaryNumberAsString[i]);
        }

        while (reversedBinaryNumberAsList.Count % 4 > 0)
        {
            reversedBinaryNumberAsList.Add(0);
        }

        string reversedBinaryNumberAsString = new string(' ', reversedBinaryNumberAsList.Count);

        reversedBinaryNumberAsString = reversedBinaryNumberAsList.ToString();

        List<string> reversedHexadecimalNumber = new List<string>();

        StringBuilder bynaryRepresentationOfHexadecimalDigit = new StringBuilder(new string('.', 4));

        string hexadecimalDigit = null;
        for (int i = 0; i < reversedBinaryNumberAsString.Length; i += 4)
        {
            for (int j = i; j < i + 4; j++)
            {
                bynaryRepresentationOfHexadecimalDigit[j - i] = Convert.ToChar(reversedBinaryNumberAsString[j - i]);
            }

            string bynaryRepresentationOfHexadecimalDigitAsString = bynaryRepresentationOfHexadecimalDigit.ToString();

            switch (bynaryRepresentationOfHexadecimalDigitAsString)
            {
                case "0000": hexadecimalDigit = "0"; break;
                case "0001": hexadecimalDigit = "1"; break;
                case "0010": hexadecimalDigit = "2"; break;
                case "0011": hexadecimalDigit = "3"; break;
                case "0100": hexadecimalDigit = "4"; break;
                case "0101": hexadecimalDigit = "5"; break;
                case "0110": hexadecimalDigit = "6"; break;
                case "0111": hexadecimalDigit = "7"; break;
                case "1000": hexadecimalDigit = "8"; break;
                case "1001": hexadecimalDigit = "9"; break;
                case "1010": hexadecimalDigit = "A"; break;
                case "1011": hexadecimalDigit = "B"; break;
                case "1100": hexadecimalDigit = "C"; break;
                case "1101": hexadecimalDigit = "D"; break;
                case "1110": hexadecimalDigit = "E"; break;
                case "1111": hexadecimalDigit = "F"; break;
                default: hexadecimalDigit = "Bad! "; break;
            }

            reversedHexadecimalNumber.Add(hexadecimalDigit);
        }

        for (int i = reversedHexadecimalNumber.Count - 1; i >= 0; i--)
        {
            Console.Write(reversedHexadecimalNumber[i]);
        }
    }
}