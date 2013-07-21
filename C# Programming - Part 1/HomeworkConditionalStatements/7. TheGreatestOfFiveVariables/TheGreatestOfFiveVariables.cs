//Write a program that finds the greatest of given 5 variables.

using System;

class TheGreatestOfFiveVariables
{
    static void Main()
    {
        Console.WriteLine("Please enter 5 different numbers to find the biggest one: ");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());
        int e = int.Parse(Console.ReadLine());
        if (a > b && a > c && a > d && a > e)
        {
            Console.WriteLine("The greatest variable is: {0}", a);
        }
        else if (b > a && b > c && b > d && b > e)
        {
            Console.WriteLine("The greatest variable is: {0}", b);
        }
        else if (c > a && c > b && c > d && c > e)
        {
            Console.WriteLine("The greatest variable is: {0}", c);
        }
        else if (d > a && d > b && d > c && d > e)
        {
            Console.WriteLine("The greatest variable is: {0}", d);
        }
        else if (e > a && e > b && e > c && e > d)
        {
            Console.WriteLine("The greatest variable is: {0}", e);
        }
        else
        {
            Console.WriteLine("Please enter different numbers to find the biggest one.");
        }
    }
}