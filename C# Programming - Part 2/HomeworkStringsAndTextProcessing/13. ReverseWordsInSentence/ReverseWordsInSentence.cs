////Write a program that reverses the words in given sentence.
////Example: "C# is not C++, not PHP and not Delphi!"  "Delphi not and PHP, not C++ not is C#!".

using System;
using System.Linq;

class ReverseWordsInSentence
{
    static void Main()
    {
        string inputString = "C# is not C++, not PHP and not Delphi!";

        string[] inputStringAsArray = inputString.Split(' ');

        for (int i = inputStringAsArray.Length - 1; i >= 0; i--)
        {
            Console.Write(inputStringAsArray[i] + " ");
        }
        Console.WriteLine();
    }
}