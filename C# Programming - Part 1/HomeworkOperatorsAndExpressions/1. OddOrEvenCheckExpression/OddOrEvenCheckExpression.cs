//Write an expression that checks if given integer is
//odd or even.

using System;

class OddOrEvenCheckExpression
{
    static void Main()
    {
        Console.Write("Please input integer to check whether it is even or odd: ");
        int inputNumber = int.Parse(Console.ReadLine());
        Console.WriteLine(inputNumber % 2 == 0 ? "The number is even." : "The number is odd");
    }
}