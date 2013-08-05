//Write a program that shows the binary representation of 
//given 16-bit signed integer number (the C# type short).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BinaryRepresentationOfShortNumber
{
    static void Main()
    {
        Console.Write("Enter short number: ");
        short shortNumber = short.Parse(Console.ReadLine());

        BinaryConverting(shortNumber);
    }

    // This method converts the possitive short decimal number to binary.
    public static List<short> ConvertToPossitiveBinaryNumber(int shortNumber)
    {
        List<short> reversedBinaryRepresentation = new List<short>();

        while (shortNumber > 0)
        {
            reversedBinaryRepresentation.Add((short)(shortNumber % 2));
            shortNumber = (short)(shortNumber / 2);
        }
        int reversedBinaryRepresentationCount = reversedBinaryRepresentation.Count;
        for (int i = reversedBinaryRepresentationCount; i < 16; i++)
        {
            reversedBinaryRepresentation.Add((short)0);
        }

        return reversedBinaryRepresentation;
    }

    public static void BinaryConverting(int shortNumber)
    {
        if (shortNumber == -32768)
        {
            Console.WriteLine("The corresponding binary number is: 1000000000000000");
        }
        else if (shortNumber >= 0)
        {
            PrintResult(ConvertToPossitiveBinaryNumber(shortNumber));
        }
        else if (shortNumber < 0)
        {
            // Making the number possitive and than represent it as negative.
            int negativeShortNumber = -shortNumber;

            List<short> reversedBinaryRepresentation = ConvertToPossitiveBinaryNumber(negativeShortNumber);

            // This part of code which reverse the bits to looks like negative, and adds "1" as least significant bit.
            //............................................................
            for (int i = 0; i < reversedBinaryRepresentation.Count; i++)
            {
                if (reversedBinaryRepresentation[i] == 0)
                {
                    reversedBinaryRepresentation[i] = 1;
                }
                else if (reversedBinaryRepresentation[i] == 1)
                {
                    reversedBinaryRepresentation[i] = 0;
                }
            }
            reversedBinaryRepresentation[0] = 1;
            //............................................................

            PrintResult(reversedBinaryRepresentation);
        }
    }

    public static void PrintResult(List<short> reversedBinaryRepresentation)
    {
        Console.Write("The corresponding binary number is: ");
        for (int i = reversedBinaryRepresentation.Count - 1; i >= 0; i--)
        {
            Console.Write(reversedBinaryRepresentation[i]);
        }
        Console.WriteLine();
    }
}