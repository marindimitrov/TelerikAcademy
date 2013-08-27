////Write a program that reads a string, reverses it and prints the result at the console.
////Example: "sample"  "elpmas".

using System;

class ReadReverseAndPrintString
{
    static void Main()
    {
        string inputString = "abcdefg";
        char[] inputStringAsCharArray = inputString.ToCharArray();
        Array.Reverse(inputStringAsCharArray);
        Console.WriteLine(new string(inputStringAsCharArray));
    }
}