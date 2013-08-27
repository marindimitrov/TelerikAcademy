////Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".

using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

class ExtractPalindromesFromText
{
    static void Main()
    {
        string inputText = ReadInputText(@"..\text.txt");

        StringBuilder result = FindPalindromes(inputText);

        Console.WriteLine("Palindromes are: ",result);
    }
    public static string ReadInputText(string readedFilePath)
    {
        string inputText = null;

        StreamReader reader = new StreamReader(readedFilePath);
        using (reader)
        {
            inputText = reader.ReadToEnd();
        }
        return inputText;
    }
    static StringBuilder FindPalindromes(string inputText)
    {
        string[] inputTextArray = Regex.Split(inputText, "[^a-zA-Z]+");

        StringBuilder result = new StringBuilder();

        foreach (string word in inputTextArray)
        {
            bool check = true;
            for (int i = 0, j = word.Length - 1; i < word.Length / 2; i++, j--)
            {
                if (word[i] != word[j])
                {
                    check = false;
                    break;
                }
            }
            if (check == true)
            {
                result.Append(word + " ");
            }
        }
        return result;
    }
}