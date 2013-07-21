//Write an expression that checks for given integer if 
//its third digit (right-to-left) is 7. E. g. 1732  true.

using System;

class CheckIntTrirdDigitIfSeven
{
    static void Main()
    {
        Console.Write("Enter number and check whether its third digit is 7: ");
        long inputNumber = long.Parse(Console.ReadLine());
        long firstCheck = inputNumber / 100;
        long thirdDigit = firstCheck % 10;
        Console.WriteLine(thirdDigit == 7 ? "The third number is 7." : "The third number is not 7.");
    }
}