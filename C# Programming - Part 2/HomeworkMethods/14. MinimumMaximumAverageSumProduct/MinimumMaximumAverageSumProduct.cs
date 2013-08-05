//Write methods to calculate minimum, maximum, 
//average, sum and product of given set of integer 
//numbers. Use variable number of arguments.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MinimumMaximumAverageSumProduct
{
    static void Main()
    {
        int[] array = new int[] { 5, 1, 6, 8, 5, 7, 3, 2, 5, 2, 4, 3, 7, 5 };
        Console.WriteLine("Мinimal integer: {0}", Miminum(array));
        Console.WriteLine("Maximal integer: {0}", Maximum(array));
        Console.WriteLine("Average: {0}", Average(array));
        Console.WriteLine("Sum of all integers: {0}", Sum(array));
        Console.WriteLine("Product of all integers: {0}", Product(array));
    }

    public static int Miminum(int[] array)
    {
        int minimum = int.MaxValue;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < minimum)
            {
                minimum = array[i];
            }
        }
        return minimum;
    }

    public static int Maximum(int[] array)
    {
        int maximum = int.MinValue;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maximum)
            {
                maximum = array[i];
            }
        }
        return maximum;
    }

    public static decimal Average(int[] array)
    {
        int sumOfAllIntegers = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sumOfAllIntegers = sumOfAllIntegers + array[i];
        }
        decimal average = sumOfAllIntegers / array.Length;
        return average;
    }

    public static int Sum(int[] array)
    {
        int sumOfAllIntegers = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sumOfAllIntegers = sumOfAllIntegers + array[i];
        }
        return sumOfAllIntegers;
    }

    public static int Product(int[] array)
    {
        int productOfAllIntegers = 1;
        for (int i = 0; i < array.Length; i++)
        {
            productOfAllIntegers = productOfAllIntegers * array[i];
        }
        return productOfAllIntegers;
    }
}