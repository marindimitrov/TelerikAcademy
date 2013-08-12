//You are given a sequence of positive integer values written into a string, separated by spaces. 
//Write a function that reads these values from given string and calculates their sum. 
//Example: string = "43 68 9 23 318"  result = 461

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CalculateSumOfValuesFromString
{
    static void Main()
    {
        Console.WriteLine("Please enter sequence of integer calues, separated by spaces:");
        string inputString = Console.ReadLine();

        string[] separator = new string[] { " " };
        string[] valuesAsSeparatedStringsWithoutSpaces;
        valuesAsSeparatedStringsWithoutSpaces = inputString.Split(separator, StringSplitOptions.RemoveEmptyEntries);

        int[] valuesAsSeparatedIntegers = new int[valuesAsSeparatedStringsWithoutSpaces.Length];
        for (int i = 0; i < valuesAsSeparatedStringsWithoutSpaces.Length; i++)
        {
            valuesAsSeparatedIntegers[i] = int.Parse(valuesAsSeparatedStringsWithoutSpaces[i]);
        }

        int sumOfSeparatedIntegers = 0;
        for (int i = 0; i < valuesAsSeparatedIntegers.Length; i++)
        {
            sumOfSeparatedIntegers += valuesAsSeparatedIntegers[i];
        }
        Console.WriteLine("The sum of the entered integers is: {0}.", sumOfSeparatedIntegers);
    }
}