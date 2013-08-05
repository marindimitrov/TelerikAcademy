//Write a method that adds two positive integer 
//numbers represented as arrays of digits (each 
//array element arr[i] contains a digit; the last 
//digit is kept in arr[0]). Each of the numbers 
//that will be added could have up to 10 000 digits.

using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class IntNumbersRepresentedAsArraysOfDigits
{
    static void Main()
    {
        Console.WriteLine("Please enter the first number: ");
        BigInteger firstNum = BigInteger.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the second number: ");
        BigInteger secondNum = BigInteger.Parse(Console.ReadLine());

        AddsArrayNumbers(firstNum, secondNum);
    }

    public static void AddsArrayNumbers(BigInteger firstNum, BigInteger secondNum)
    {
        string firstNumAsString = firstNum.ToString();
        string secondNumAsString = secondNum.ToString();

        int[] firstNumAsArray = new int[10000];
        int[] secondNumAsArray = new int[10000];

        for (int i = firstNumAsString.Length - 1, j = 0; i >= 0; i--, j++)
        {
            firstNumAsArray[j] = (int)firstNumAsString[i] - 48;
        }
        for (int i = secondNumAsString.Length - 1, j = 0; i >= 0; i--, j++)
        {
            secondNumAsArray[j] = (int)secondNumAsString[i] - 48;
        }

        int[] result = new int[10000];

        result[0] = (firstNumAsArray[0] + secondNumAsArray[0]) % 10;
        for (int i = 1; i < 10000; i++)
        {
            result[i] = ((firstNumAsArray[i] + secondNumAsArray[i]) % 10) +
                        ((firstNumAsArray[i - 1] + secondNumAsArray[i - 1]) / 10);
        }

        Console.WriteLine("The result is: ");
        for (int i = result.Length - 1; i >= 0; i--)
        {
            Console.Write(result[i]);
        }
    }
}