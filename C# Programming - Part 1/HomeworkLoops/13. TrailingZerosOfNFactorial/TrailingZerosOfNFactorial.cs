﻿//* Write a program that calculates for given N 
//how many trailing zeros present at the end of 
//the number N!. Examples:
//    N = 10  N! = 3628800  2
//    N = 20  N! = 2432902008176640000  4
//Does your program work for N = 50 000?
//Hint: The trailing zeros in N! are equal to 
//the number of its prime divisors of value 5. Think why!

using System;
using System.Numerics;

class TrailingZerosOfNFactorial
{
    static void Main()
    {
        Console.Write("Enter N: ");
        BigInteger n = BigInteger.Parse(Console.ReadLine());

        BigInteger nFactorial = 1;
        while (n > 0)
        {
            nFactorial *= n;
            n--;
        }
        Console.WriteLine("\nN! is {0}." ,nFactorial);

        BigInteger divided = nFactorial;
        BigInteger counter = 0;
        while (divided % 10 == 0)
        {
           divided = divided/10;
           counter++;
        }
        Console.WriteLine("\nThe number of trailing zeros is {0}.\n" ,counter);
    }
}