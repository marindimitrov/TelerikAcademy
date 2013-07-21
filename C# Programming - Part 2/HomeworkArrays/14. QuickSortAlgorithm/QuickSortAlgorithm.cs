//Write a program that sorts an array of strings using 
//the quick sort algorithm (find it in Wikipedia).

using System;

public class QuickSortAlgorithm
{
    public static void Main()
    {
        Console.Write("Enter unsorted array length: ");
        int n = int.Parse(Console.ReadLine());

        int[] inputArray = new int[n];

        Console.WriteLine("Enter array elements:");
        for (int el = 0; el < inputArray.Length; el++)                  //Entering the elements of unsorted input array.
        {
            inputArray[el] = int.Parse(Console.ReadLine());         
        }

        QuickSorting(inputArray, 0, inputArray.Length - 1);             //Calling Quick Sorting function and execution.

        Console.WriteLine("The sorted array series is:");
        for (int el = 0; el < inputArray.Length; el++)                  //Printing the sorted elements on the console.
        {
            Console.Write("{0} ", inputArray[el]);
        }
        Console.WriteLine();
    }

    public static void QuickSorting(int[] array, int left, int right)   //Quick Sorting algorithm implementation.
    {
        if (left >= right)
        {
            return;
        }

        int leftIndex = left;
        int rightIndex = right;
        int fulcrum = array[right];

        while (leftIndex < rightIndex)
        {
            while (leftIndex < rightIndex && array[leftIndex] <= fulcrum)
            {
                leftIndex++;
            }
            while (leftIndex < rightIndex && array[rightIndex] >= fulcrum)
            {
                rightIndex--;
            }
            if (leftIndex < rightIndex)
            {
                int t = array[leftIndex];
                array[leftIndex] = array[rightIndex];
                array[rightIndex] = t;
            }
        }
        int tempForExchange = array[leftIndex];
        array[leftIndex] = array[right];
        array[right] = tempForExchange;

        QuickSorting(array, left, leftIndex - 1);
        QuickSorting(array, leftIndex + 1, right);
    }
}