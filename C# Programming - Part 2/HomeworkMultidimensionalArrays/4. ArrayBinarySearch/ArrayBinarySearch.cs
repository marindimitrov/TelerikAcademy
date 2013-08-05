//Write a program, that reads from the console an 
//array of N integers and an integer K, sorts the 
//array and using the method Array.BinSearch() finds 
//the largest number in the array which is ≤ K. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ArrayBinarySearch
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[] arrayOfIntegers = new int[n];

        for (int i = 0; i < arrayOfIntegers.Length; i++)
        {
            arrayOfIntegers[i] = int.Parse(Console.ReadLine());
        }

        int k = int.Parse(Console.ReadLine());

        Array.Sort(arrayOfIntegers);

        int index = Array.BinarySearch(arrayOfIntegers, k);

        if (index >= 0)
        {
            Console.Write("The largest number in array, which is <= K is: ");
            Console.WriteLine(arrayOfIntegers[index]);
        }

        // In other variants below we use the fact that "Array.BinarySearch" 
        // returns negative number, which is the index of the first eventual 
        // number bigger than input integer K, backwards from 0. 
        else if (index == -1)
        {
            Console.WriteLine("There is no such value.");
        }
        else
        {
            Console.Write("The largest number in array, which is <= K is: ");
            Console.WriteLine(arrayOfIntegers[-index - 2]);
        }
    }
}