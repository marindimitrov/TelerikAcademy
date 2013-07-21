//Write an if statement that examines two integer 
//variables and exchanges their values if the first one 
//is greater than the second one.

using System;

class ExchangesGreaterIntegerWithIfStatement
{
    static void Main()
    {
        Console.Write("Enter the first integer: ");
        int firstInt = int.Parse(Console.ReadLine());
        Console.Write("Enter the second integer: ");
        int secondInt = int.Parse(Console.ReadLine());
        int exchange;
        if (firstInt > secondInt)
        {
            exchange = firstInt;
            firstInt = secondInt;
            secondInt = exchange;
            Console.WriteLine("The first integer is bigger than the second integer, and the result is: ");
            Console.WriteLine("First Integer = {0}\nSecond Integer = {1}", firstInt, secondInt);
        }
        else if (firstInt < secondInt)
        {
            Console.WriteLine("The first integer is smaller than the second integer, and the result is: ");
            Console.WriteLine("First Integer = {0}\nSecond Integer = {1}", firstInt, secondInt);
        }
        else
        {
            Console.WriteLine("The input numbers are equal.");
        }
    }
}