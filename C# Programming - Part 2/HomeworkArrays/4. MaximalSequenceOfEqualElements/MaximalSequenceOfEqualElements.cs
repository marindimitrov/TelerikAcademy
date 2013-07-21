//Write a program that finds the maximal sequence of equal elements in an array.
//Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1}  {2, 2, 2}.

using System;

class MaximalSequenceOfEqualElements
{
    static void Main()
    {
        Console.Write("Enter the array length: ");
        int arrayLength = int.Parse(Console.ReadLine());

        int[] array = new int[arrayLength];
        for (int i = 0; i < array.Length; i++)                      //Filling the inspected array.
        {
            Console.Write("Enter array element {0}: ", i + 1);
            array[i] = int.Parse(Console.ReadLine());
        }

        int subEnd = 0;
        int count = 1;
        int maxCount = 0;

        for (int i = 0; i < array.Length - 1; i++)                  //Finding the longest sequence.
        {
            if (array[i] == array[i + 1])
            {
                count++;
            }
            else if (array[i] != array[i + 1] && count > maxCount)
            {
                maxCount = count;
                subEnd = i;
                count = 1;
            }
            else if (array[i] != array[i + 1])
            {
                count = 1;
            }
        }

        for (int i = subEnd - maxCount + 1; i <= subEnd; i++)       //Printing the result.
        {
            Console.Write("{0} ", array[i]);
        }
        Console.WriteLine();
    }
}