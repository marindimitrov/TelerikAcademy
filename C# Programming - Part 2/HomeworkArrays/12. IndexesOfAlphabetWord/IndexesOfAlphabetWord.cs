//Write a program that creates an array containing all letters 
//from the alphabet (A-Z). Read a word from the console and 
//print the index of each of its letters in the array.

using System;

class IndexesOfAlphabetWord
{
    static void Main()
    {
        char[] alphabetArray = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l','m', 
                                         'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};

        Console.WriteLine("Enter word (lowercase letters only): ");
        string word = Console.ReadLine();

        Console.WriteLine("Searched array indexes for the entered word are:");
        for (int wordLetter = 0; wordLetter < word.Length; wordLetter++)
        {
            int small = 0;
            int big = alphabetArray.Length - 1;
            int middle = (big - small) / 2;
            int searchedIndex = 0;
            char searchedChar = word[wordLetter];

            if (word[wordLetter] == 'z')
            {
                Console.Write("{0} ", 25);
            }
            else
            {
                while (alphabetArray[middle] != searchedChar)
                {
                    if (searchedChar > alphabetArray[small + (big - small) / 2])
                    {
                        small = middle;
                        middle = small + (big - small) / 2;
                    }
                    else if (searchedChar < alphabetArray[small + (big - small) / 2])
                    {
                        big = middle;
                        middle = small + (big - small) / 2;
                    }
                }
                searchedIndex = middle;
                Console.Write("{0} ", searchedIndex);
            }
        }
        Console.WriteLine();
    }
}