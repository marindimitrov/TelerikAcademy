////Write a program that converts a string to a sequence of C# Unicode character literals. 
////Use format strings. Sample input:
////    Hi!
////Expected output:
////    \u0048\u0069\u0021

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ConvertStringToUnicodeCharLiterals
{
    static void Main()
    {
        StringBuilder result = new StringBuilder();
        string input = "Hi!";
        int charAsInt = 0;

        foreach (var item in input)
        {
            charAsInt = item;
            string toAppend = string.Format("\\u00{0:X}", charAsInt);
            result.Append(toAppend);
        }
        Console.WriteLine(result);
    }
}