//Write a method that return the maximal element in 
//a portion of array of integers starting at given index. 
//Using it write another method that sorts an array in 
//ascending / descending order.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MaximalElementAndSortsAnArray
{
    static void Main()
    {
        int[] array = new int[] { 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 1, 2, 3, 4, 5 };
        int startingIndex = 4;

        Console.Write("The maximal element in pointed part of array is: ");
        Console.WriteLine(MaximalElement(array, startingIndex));

        Console.WriteLine("Ascending sorted array:");
        PrintArray(AscendingSortArray(array));

        Console.WriteLine("Descending sorted array:");
        PrintArray(DescendingSortArray(array));
    }

    public static int MaximalElement(int[] array, int startingIndex)
    {
        int biggestNum = 0;
        for (int i = startingIndex; i < array.Length; i++)
        {
            if (array[i] > biggestNum)
            {
                biggestNum = array[i];
            }
        }
        return biggestNum;
    }

    public static int[] AscendingSortArray(int[] array)
    {
        Array.Sort(array);

        return array;
    }

    public static int[] DescendingSortArray(int[] array)
    {
        Array.Sort(array);

        int[] descendingSortedArray = new int[array.Length];

        for (int i = 0, j = array.Length - 1; i < array.Length; i++, j--)
        {
            descendingSortedArray[j] = array[i];
        }

        return descendingSortedArray;
    }

    public static void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }
}