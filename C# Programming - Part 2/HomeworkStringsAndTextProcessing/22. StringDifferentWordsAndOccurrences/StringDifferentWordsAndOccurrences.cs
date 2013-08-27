//Write a program that reads a string from the console and lists all different 
//words in the string along with information how many times each word is found.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class StringDifferentWordsAndOccurrences
{
    static void Main()
    {
        string inputString = "Some words you can see twice or more, catch these words or you can just see some words see see see.";
        Dictionary<string, int> dict = CollectWordsAndOccurrences(inputString);
        PrintResults(dict);
    }
    public static Dictionary<string, int> CollectWordsAndOccurrences(string inputString)
    {
        string[] inputStringArray = Regex.Split(inputString, "[^a-zA-Z]+");

        Dictionary<string, int> dict = new Dictionary<string, int>();

        foreach (var word in inputStringArray)
        {
            if (dict.ContainsKey(word))
            {
                dict[word] = dict[word] + 1;
            }
            else
            {
                dict.Add(word, 1);
            }
        }
        return dict;
    }
    public static void PrintResults(Dictionary<string, int> dict)
    {
        foreach (KeyValuePair<string, int> item in dict)
        {
            Console.WriteLine("The word \"{0}\" occurs {1} times", item.Key, item.Value);
        }
    }
}