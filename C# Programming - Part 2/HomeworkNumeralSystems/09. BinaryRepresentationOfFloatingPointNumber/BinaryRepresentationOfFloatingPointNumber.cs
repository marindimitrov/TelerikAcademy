//* Write a program that shows the internal binary 
//representation of given 32-bit signed floating-point 
//number in IEEE 754 format (the C# type float). 
//Example: -27,25  sign = 1, exponent = 10000011, mantissa = 10110100000000000000000.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

class BinaryRepresentationOfFloatingPointNumber
{
    static void Main()
    {
        Console.Write("Enter floating point number: ");
        float number = float.Parse(Console.ReadLine()); 
 
        Sign(number);

        // Remove the sign from the input number.
        if (number < 0)
        {
            number *= -1;
        }

        Exponent(number);

        Mantissa(number);
    }

    static void Sign(float number)
    {
        List<int> sign = new List<int>(1);

        if (number >= 0)
        {
            sign.Add(0);
        }
        else if (number < 0)
        {
            sign.Add(1);
        }

        Console.Write("Sign: ");
        Print(sign);
    }

    static void Exponent(float number)
    {
        List<int> exponent = new List<int>();

        List<int> temp = new List<int>();

        int numberWholePart = (int)number;
        while (numberWholePart > 0)
        {
            temp.Add(numberWholePart % 2);
            numberWholePart = numberWholePart / 2;
        }

        int exponentAsDecimalNumber = temp.Count + 126;
        while (exponentAsDecimalNumber > 0)
        {
            exponent.Add(exponentAsDecimalNumber % 2);
            exponentAsDecimalNumber = exponentAsDecimalNumber / 2;
        }
        exponent.Reverse();

        while (exponent.Count < 8)
        {
            exponent.Add(0);
        }

        Console.Write("Exponent: ");
        Print(exponent);
    }

    static void Mantissa(float number)
    {
        List<int> mantissa = new List<int>();

        int numberWholePart = (int)number;
        int numberWholePartConst = numberWholePart;

        while (numberWholePart > 0)
        {
            mantissa.Add(numberWholePart % 2);
            numberWholePart = numberWholePart / 2;
        }
        mantissa.Reverse();
        mantissa.RemoveAt(0);

        float numberFractionalPart = number - numberWholePartConst;

        int s = 1;
        while (mantissa.Count < 23)
        {
            if (1 / (float)Math.Pow(2, s) > numberFractionalPart )
            {
                mantissa.Add(0);
            }
            else
            {
                mantissa.Add(1);
                numberFractionalPart -= (float)Math.Pow(2, s);
            }
            s++;
        }

        Console.Write("Mantissa: ");
        Print(mantissa);
    }

    static void Print(List<int> result)
    {
        for (int i = 0; i < result.Count; i++)
        {
            Console.Write(result[i]);
        }
        Console.WriteLine();
    }
}