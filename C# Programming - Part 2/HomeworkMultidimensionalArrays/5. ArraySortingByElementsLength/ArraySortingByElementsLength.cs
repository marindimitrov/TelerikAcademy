//You are given an array of strings. Write a method 
//that sorts the array by the length of its elements 
//(the number of characters composing them).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ArraySortingByElementsLength
{
    static void Main()
    {
        string[] stringArray = new string[] {"abcdefg", "ab", "abc", "ab", "abcdef", "abcde"};

        ArraySorting(stringArray);
        
        PrintArray(stringArray);
    }

    // We use another array of integers to hold the elements lengths 
    // of array of strings, sort it and put it in string array again. 
    public static void ArraySorting(string[] stringArray)
    {
        int[] intArray = new int[stringArray.Length];

        for (int i = 0; i < stringArray.Length; i++)
        {
            intArray[i] = stringArray[i].Length;
        }

        Array.Sort(intArray);

        string[] sortedStringArray = new string[stringArray.Length];

        for (int i = 0; i < sortedStringArray.Length; i++)
        {
            for (int j = 0; j < stringArray.Length; j++)
            {
                if (stringArray[j].Length == intArray[i])
                {
                    sortedStringArray[i] = stringArray[j];
                }
            }
        }
        for (int i = 0; i < stringArray.Length; i++)
        {
            stringArray[i] = sortedStringArray[i];
        }
    }

    public static void PrintArray(string[] stringArray)
    {
        for (int i = 0; i < stringArray.Length; i++)
        {
            Console.Write("{0} ", stringArray[i]);
        }
        Console.WriteLine();
    }
}