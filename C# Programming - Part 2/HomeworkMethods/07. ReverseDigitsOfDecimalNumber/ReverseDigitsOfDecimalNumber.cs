//Write a method that reverses the digits of given decimal number. 
//Example: 256  652

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ReverseDigitsOfDecimalNumber
{
    static void Main()
    {
        Console.Write("Please enter number: ");
        int number = int.Parse(Console.ReadLine());

        Console.Write("The number with reversed digits is: ");
        ReverseNumber(number);
    }

    static void ReverseNumber(int number)
    {
        string numberAsString = number.ToString();

        for (int i = numberAsString.Length - 1; i >= 0; i--)
        {
            Console.Write(numberAsString[i]);
        }
        Console.WriteLine();
    }
}