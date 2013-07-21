//Write a program that finds the most frequent number in an array. 
//Example: {4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4 (5 times)

using System;

class FindMostFrequentNumber
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[] array = new int[n];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        int temp = 0;                                           //Sorting the elements in increasing order.
        int startingIndex = 0;

        for (int iteration = 0; iteration < n; iteration++)
        {
            for (int i = startingIndex; i < array.Length; i++)
            {
                if (array[i] < array[iteration])
                {
                    temp = array[iteration];
                    array[iteration] = array[i];
                    array[i] = temp;
                }
            }
        }                                                       //End sorting.

        int count = 1;                                          
        int maxCount = 0;
        int endIndex = 0;

        for (int i = 0; i < array.Length - 1; i++)              // Searching the maximal sequence.
        {
            if (array[i + 1] == array[i])
            {
                count++;
            }
            else if (array[i + 1] != array[i] && count > maxCount)
            {
                maxCount = count;
                endIndex = i;
                count = 1;
            }
            if (array[i + 1] == array[i] && (i + 1) == array.Length)
            {
                if (count > maxCount)
                {
                    maxCount = count;
                    endIndex = i + 1;
                }
            }
        }
        Console.WriteLine("{0}({1} times)", array[endIndex], maxCount);
    }
}