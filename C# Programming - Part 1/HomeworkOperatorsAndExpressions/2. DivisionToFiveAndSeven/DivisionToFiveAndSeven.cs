//Write a boolean expression that checks for given 
//integer if it can be divided (without remainder) by 7 
//and 5 in the same time.

using System;

class DivisionToFiveAndSeven
{
    static void Main()
    {
        Console.Write("Enter a number and check if it is divisible by 5 and 7 at the same time: ");
        int inputNum = int.Parse(Console.ReadLine());
        if (inputNum % 5 == 0)
        {
            if (inputNum % 7 == 0)
            {
                Console.WriteLine("The entered number is divisible by 5 and 7 at the same time.");
            }
            else
            {
                Console.WriteLine("The entered number is not divisible by 5 and 7 at the same time.");
            }
        }
        else
        {
            Console.WriteLine("The entered number is not divisible by 5 and 7 at the same time.");
        }
    }
}