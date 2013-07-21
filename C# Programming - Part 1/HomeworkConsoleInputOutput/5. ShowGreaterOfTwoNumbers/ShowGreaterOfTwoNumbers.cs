//Write a program that gets two numbers from the 
//console and prints the greater of them. Don’t use if 
//statements.

using System;

class ShowGreaterOfTwoNumbers
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("The greater number is: {0}", a > b ? a : b);
    }
}