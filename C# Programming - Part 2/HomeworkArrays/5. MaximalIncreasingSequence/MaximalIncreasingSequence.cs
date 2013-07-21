//Write a program that finds the maximal increasing sequence in an array. 
//Example: {3, 2, 3, 4, 2, 2, 4}  {2, 3, 4}.

using System;

class MaximalIncreasingSequence
{
    static void Main()
    {
        Console.Write("Enter the array length: ");
        int arrayLength = int.Parse(Console.ReadLine());

        int[] array = new int[arrayLength];
        for (int i = 0; i < array.Length; i++)                           //Filling the inspected array.
        {
            Console.Write("Enter array element {0}: ", i + 1);
            array[i] = int.Parse(Console.ReadLine());
        }

        int subEnd = 0;
        int count = 0;
        int maxCount = 0;

        for (int i = 0; i < array.Length - 1; i++)                       //Finding the longest sequence.
        {
            if ((array[i] + 1) == array[i + 1])
            {
                count++;
            }
            else if (((array[i] + 1) != array[i + 1]) && (count > maxCount))
            {
                maxCount = count;
                subEnd = i;
                count = 0;
            }
        }

        for (int i = subEnd - maxCount; i <= subEnd; i++)               //Printing the result.
        {
            Console.Write("{0} ", array[i]);
        }
        Console.WriteLine();
    }
}