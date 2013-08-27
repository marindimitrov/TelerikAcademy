////We are given a string containing a list of forbidden words and a text containing some of these words. 
////Write a program that replaces the forbidden words with asterisks. 
////    Example:
////        Microsoft announced its next generation PHP compiler today. 
////        It is based on .NET Framework 4.0 and is implemented as a 
////        dynamic language in CLR.
////    Words: 
////        "PHP, CLR, Microsoft"
////    The expected result:
////        ********* announced its next generation *** compiler today. 
////        It is based on .NET Framework 4.0 and is implemented as a 
////        dynamic language in ***.

using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

class ReplaceForbiddenWordsWithAsterisks
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"..\text.txt");
        string readedText = reader.ReadToEnd();
        using (reader)
        {
            string forbiddenWords = "PHP, CLR, Microsoft";

            Regex regex = new Regex(@"\b, \b");
            string[] forbWords = regex.Split(forbiddenWords);

            foreach (var item in forbWords)
            {
                readedText = readedText.Replace(item, new string('*', item.Length));
            }
        }
        StreamWriter writer = new StreamWriter(@"..\result.txt");
        using (writer)
        {
            writer.WriteLine(readedText);
        }
        Console.WriteLine(readedText);
    }
}