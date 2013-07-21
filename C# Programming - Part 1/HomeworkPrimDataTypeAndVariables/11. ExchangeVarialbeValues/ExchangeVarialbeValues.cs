using System;

class ExchangeVarialbeValues
{
    static void Main()
    {
        int firstInt = 5;
        Console.WriteLine("My first integer number is: " + firstInt);
        int secondInt = 10;
        Console.WriteLine("My second integer number is: " + secondInt);
        int sumInt = firstInt + secondInt;
        Console.WriteLine("After exchange my first integer has value of: " + (sumInt - firstInt));
        Console.WriteLine("After exchange my second integer has value of: " + (sumInt - secondInt));
    }
}
