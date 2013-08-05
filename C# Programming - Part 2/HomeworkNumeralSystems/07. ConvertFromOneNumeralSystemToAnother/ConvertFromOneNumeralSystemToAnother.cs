//Write a program to convert from any numeral system of given 
//base s to any other numeral system of base d (2 ≤ s, d ≤ 16).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ConvertFromOneNumeralSystemToAnother
{
    static void Main()
    {
        Console.WriteLine("Enter numeral system from which you want to convert (chose between 2 and 16): ");
        int firstBase = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter numeral system to which you want to convert(choose between 2 and 16): ");
        int secondBase = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter number in {0}-based numeral system: ", firstBase);
        string number = Console.ReadLine();

        PrintResultInWantedNumeralSystem(secondBase, ConvertFromDeciamlToWantedNumeral(secondBase, ConvertToDecimal(firstBase, number)));
    }

    public static int ConvertToDecimal(int firstBase, string number)
    {
        char[] numberAsCharArray = number.ToCharArray();

        Array.Reverse(numberAsCharArray);

        List<int> numeral = new List<int>();

        for (int i = 0; i < numberAsCharArray.Length; i++)
        {
            int numeralAsInt = 0;

            switch (numberAsCharArray[i])
            {
                case '0': numeralAsInt = 0; break;
                case '1': numeralAsInt = 1; break;
                case '2': numeralAsInt = 2; break;
                case '3': numeralAsInt = 3; break;
                case '4': numeralAsInt = 4; break;
                case '5': numeralAsInt = 5; break;
                case '6': numeralAsInt = 6; break;
                case '7': numeralAsInt = 7; break;
                case '8': numeralAsInt = 8; break;
                case '9': numeralAsInt = 9; break;
                case 'A': numeralAsInt = 10; break;
                case 'B': numeralAsInt = 11; break;
                case 'C': numeralAsInt = 12; break;
                case 'D': numeralAsInt = 13; break;
                case 'E': numeralAsInt = 14; break;
                case 'F': numeralAsInt = 15; break;
            }
            numeral.Add(numeralAsInt);
        }
        int numberAsDecimal = 0;

        for (int i = 0; i < numeral.Count; i++)
        {
            numberAsDecimal += numeral[i] * (int)Math.Pow(firstBase, i);
        }

        return numberAsDecimal;
    }

    public static List<int> ConvertFromDeciamlToWantedNumeral(int secondBase, int numberAsDecimal)
    {
        List<int> reversedSecondBaseNumber = new List<int>();

        while (numberAsDecimal > 0)
        {
            reversedSecondBaseNumber.Add(numberAsDecimal % secondBase);
            numberAsDecimal = numberAsDecimal / secondBase;
        }

        return reversedSecondBaseNumber;
    }

    public static void PrintResultInWantedNumeralSystem(int secondBase, List<int> reversedSecondBaseNumber)
    {
        Console.WriteLine("The number in {0}-based numeral system is:", secondBase);
        for (int i = reversedSecondBaseNumber.Count - 1; i >= 0; i--)
        {
            switch (reversedSecondBaseNumber[i])
            {
                case 10: Console.Write('A'); break;
                case 11: Console.Write('B'); break;
                case 12: Console.Write('C'); break;
                case 13: Console.Write('D'); break;
                case 14: Console.Write('E'); break;
                case 15: Console.Write('F'); break;
                default: Console.Write(reversedSecondBaseNumber[i]); break;
            }
        }
        Console.WriteLine();
    }
}