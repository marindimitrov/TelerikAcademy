////A dictionary is stored as a sequence of text lines containing words and their 
////explanations. Write a program that enters a word and translates it by using 
////the dictionary. Sample dictionary:
////    .NET – platform for applications from Microsoft
////    CLR – managed execution environment for .NET
////    namespace – hierarchical organization of classes

using System;
using System.Collections.Generic;
using System.Linq;

class TranslateWordUsingDictionary
{
    static void Main()
    {
        Dictionary<string, string> myDictionary = new Dictionary<string, string>();

        myDictionary.Add(".NET", "platform for applications from Microsoft");
        myDictionary.Add("CLR", "managed execution environment for .NET");
        myDictionary.Add("namespace","hierarchical organization of classes");

        Console.Write("Please enter a word from the dictionary: ");
        string word = Console.ReadLine();
        
        string value = "";
        if (myDictionary.TryGetValue(word, out value))
        {
            Console.WriteLine("The meaning of {0} is: {1}.", word, value);
        }
        else
        {
            Console.WriteLine("Word {0} is not found in dictionary.", word);
        }
    }
}