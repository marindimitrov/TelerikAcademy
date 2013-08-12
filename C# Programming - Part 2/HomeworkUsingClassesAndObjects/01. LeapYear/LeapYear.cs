//Write a program that reads a year from the console and checks whether it is a leap. Use DateTime.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class LeapYear
{
    static void Main()
    {
        Console.Write("Please enter a year: ");
        int input = int.Parse(Console.ReadLine());

        if (DateTime.IsLeapYear(input))
        {
            Console.WriteLine("The year {0} is leap year", input);
        }
        else
        {
            Console.WriteLine("The year {0} is common year.", input);
        }
    }
}