////Write a program that reads a list of words, separated 
////by spaces and prints the list in an alphabetical order.

using System;
using System.Linq;
using System.Text.RegularExpressions;

class PrintListInAlphabeticalOrder
{
    static void Main()
    {
        string words = "hi there hello fly down go sky man women properties references";

        string[] wordsList = Regex.Split(words, "[^a-zA-Z]+");

        Array.Sort(wordsList);

        foreach (var item in wordsList)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}