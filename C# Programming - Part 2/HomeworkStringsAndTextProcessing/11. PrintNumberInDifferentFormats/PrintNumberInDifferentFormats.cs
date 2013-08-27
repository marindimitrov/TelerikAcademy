////Write a program that reads a number and prints it as a decimal number, 
////hexadecimal number, percentage and in scientific notation. Format the 
////output aligned right in 15 symbols.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PrintNumberInDifferentFormats
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int input = int.Parse(Console.ReadLine());
        Console.WriteLine("Printed results are as decimal number, hexidecimal number, percentage and scientific notation, as follows:");
        Console.WriteLine("{0,15:D}\n{0,15:X}\n{0,15:P}\n{0,15:E}\n", input);
    }
}