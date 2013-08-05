//Write a method that counts how many times given number appears in given array. 
//Write a test program to check if the method is working correctly.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class TimesNumberAppearInArray
{
    static void Main()
    {
        int[] array = new int[] { 5, 3, 4, 7, 9, 5, 2, 5, 8 };
        int number = 5;

        Console.WriteLine("The number {0} appears {1} times in the array.", number, Counter(array, number));
    }
    public static int Counter(int[] array, int number)
    {
        int counter = 0;
        foreach (var num in array)
        {
            if (num == number)
            {
                counter++;
            }
        }
        return counter;
    }
}