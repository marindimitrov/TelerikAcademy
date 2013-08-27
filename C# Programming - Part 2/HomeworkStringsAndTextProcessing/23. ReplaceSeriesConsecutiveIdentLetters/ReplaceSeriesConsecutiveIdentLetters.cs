////Write a program that reads a string from the console and replaces all series of consecutive 
////identical letters with a single one. Example: "aaaaabbbbbcdddeeeedssaa"  "abcdedsa".

using System;
using System.Linq;
using System.Text;

class ReplaceSeriesConsecutiveIdentLetters
{
    static void Main()
    {
        string input = "aaaaabbbbbcdddeeeedssaa";

        StringBuilder singleLetters = new StringBuilder();

        singleLetters.Append(input[0]);
        for (int i = 1; i < input.Length; i++)
        {
            if (input[i] != input[i-1])
            {
                singleLetters.Append(input[i]);
            }
        }
        Console.WriteLine(singleLetters);
    }
}