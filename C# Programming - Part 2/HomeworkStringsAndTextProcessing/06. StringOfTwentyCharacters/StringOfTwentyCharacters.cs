﻿////Write a program that reads from the console a string of maximum 20 characters. 
////If the length of the string is less than 20, the rest of the characters should 
////be filled with '*'. Print the result string into the console.

using System;

class StringOfTwentyCharacters
{
    static void Main()
    {
        string inputString = Console.ReadLine();

        if (inputString.Length >= 20)
        {
            Console.WriteLine(inputString);
        }
        else
        {
            Console.WriteLine(inputString + new String('*', 20 - inputString.Length));
        }
    }
}