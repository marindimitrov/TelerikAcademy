//Write a program to convert hexadecimal numbers to binary numbers (directly).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ConvertHexadecimalNumbersToBinary
{
    static void Main()
    {
        Console.Write("Please enter hexadecimal number: ");
        string hexadecimalNumberAsString = Console.ReadLine();
        List<int> hexadecimalNumberAsList = new List<int>();
        List<int> reversedBinaryNumber = new List<int>();
        List<int> binaryNumber = new List<int>();

        AssociateHexadecimalSymbols(hexadecimalNumberAsString, hexadecimalNumberAsList);
        Converter(hexadecimalNumberAsList, reversedBinaryNumber);
        Console.Write("The binary representation of the number is: ");
        PrintResult(binaryNumber, reversedBinaryNumber);
    }

    // Making hexadecimal symbols to their integer representation.
    public static void AssociateHexadecimalSymbols(string hexadecimalNumberAsString, List<int> hexadecimalNumberAsList)
    {
        for (int i = hexadecimalNumberAsString.Length - 1; i >= 0; i--)
        {
            if (hexadecimalNumberAsString[i] == 'A' || hexadecimalNumberAsString[i] == 'B' ||
                hexadecimalNumberAsString[i] == 'C' || hexadecimalNumberAsString[i] == 'D' ||
                hexadecimalNumberAsString[i] == 'E' || hexadecimalNumberAsString[i] == 'F')
            {
                hexadecimalNumberAsList.Add(hexadecimalNumberAsString[i] - 55);
            }
            else if (hexadecimalNumberAsString[i] == '0' || hexadecimalNumberAsString[i] == '1' ||
                     hexadecimalNumberAsString[i] == '2' || hexadecimalNumberAsString[i] == '3' ||
                     hexadecimalNumberAsString[i] == '4' || hexadecimalNumberAsString[i] == '5' ||
                     hexadecimalNumberAsString[i] == '6' || hexadecimalNumberAsString[i] == '7' ||
                     hexadecimalNumberAsString[i] == '8' || hexadecimalNumberAsString[i] == '9')
            {
                hexadecimalNumberAsList.Add(hexadecimalNumberAsString[i] - 48);
            }
        }
    }

    // The real algorithm converting every hexadeciaml digit to its 4-bit binary representation.
    public static void Converter(List<int> hexadecimalNumberAsList, List<int> reversedBinaryNumber)
    {
        List<int> binaryPortionOfNumber = new List<int>();

        for (int i = 0; i < hexadecimalNumberAsList.Count; i++)
        {
            while (hexadecimalNumberAsList[i] > 0)
            {
                binaryPortionOfNumber.Add(hexadecimalNumberAsList[i] % 2);
                hexadecimalNumberAsList[i] = hexadecimalNumberAsList[i] / 2;
            }

            int residue = 4 - binaryPortionOfNumber.Count;
            for (int j = 0; j < residue; j++)
            {
                binaryPortionOfNumber.Add(0);
            }

            // add 4-bit hexadecimal digit as a part of the whole binay represented number in reverse order.
            for (int j = 0; j < binaryPortionOfNumber.Count; j++)
            {
                reversedBinaryNumber.Add(binaryPortionOfNumber[j]);
            }
            binaryPortionOfNumber.Clear();
        }
    }

    public static void PrintResult(List<int> binaryNumber, List<int> reversedBinaryNumber)
    {
        for (int i = reversedBinaryNumber.Count - 1; i >= 0; i--)
        {
            binaryNumber.Add(reversedBinaryNumber[i]);
        }

        for (int i = 0; i < binaryNumber.Count; i++)
        {
            Console.Write(binaryNumber[i]);
        }
        Console.WriteLine();
    }
}