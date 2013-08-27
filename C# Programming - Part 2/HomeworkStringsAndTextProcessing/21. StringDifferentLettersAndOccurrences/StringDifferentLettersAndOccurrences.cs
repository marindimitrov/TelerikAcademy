////Write a program that reads a string from the console and prints all different 
////letters in the string along with information how many times each letter is found. 

using System;

class StringDifferentLettersAndOccurrences
{
    static void Main()
    {
        string inputString = "This is the srting and it contains many different letters. How many are they?";

        int[] symbolsAndCounts = CalculateSymbols(inputString);

        PrintResult(symbolsAndCounts);
    }
    public static int[] CalculateSymbols(string inputString)
    {
        char[] inputStringAsCharArray = inputString.ToCharArray();

        char[] pattern = new char[128];
        for (int i = 0; i < pattern.Length; i++)
        {
            pattern[i] = (char)i;
        }

        int[] counts = new int[128];

        foreach (var symbol in inputStringAsCharArray)
        {
            for (int i = 0; i < pattern.Length; i++)
            {
                if (pattern[i] == symbol)
                {
                    counts[i]++;
                }
            }
        }
        return counts;
    }
    public static void PrintResult(int[] counts)
    {
        for (int i = 0; i < counts.Length; i++)
        {
            if (counts[i] != 0)
            {
                Console.WriteLine("Letter \"{0}\" occurs {1} times", (char)i, counts[i]);
            }
        }
    }
}