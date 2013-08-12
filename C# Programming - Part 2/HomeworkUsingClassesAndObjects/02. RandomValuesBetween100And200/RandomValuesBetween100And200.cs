//Write a program that generates and prints to the console 10 random values in the range [100, 200].

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class RandomValuesBetween100And200
{
    static void Main()
    {
        Random randomNumber = new Random();
        Console.WriteLine("Below ara 10 random numbers in range 100 - 200.");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("{0,2}. {1}", i + 1, randomNumber.Next(100, 201));
        }
    }
}