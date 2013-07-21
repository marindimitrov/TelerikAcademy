//Write a program that gets a number n and after that 
//gets more n numbers and calculates and prints their 
//sum. 

using System;

class CalculatesSumOfNNumbers
{
    static void Main()
    {
        double sum = 0;
        while (true)
        {
            Console.Write("Enter number: ");
            string input = Console.ReadLine();
            double number;
            if (double.TryParse(input, out number))
            {
                Console.Write("The sum of the last two numbers above is: ");
                sum = sum + number;
                Console.WriteLine(sum);
            }
            else
            {
                Console.WriteLine("The input is not a number, the program is about to break.");
                break;
            }
        }
    }
}