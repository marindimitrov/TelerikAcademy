//Write a program that finds the sequence of maximal sum in given array. 
//Example: {2, 3, -6, -1, 2, -1, 6, 4, -8, 8}  {2, -1, 6, 4}
//Can you do it with only one loop (with single scan through the elements of the array)?

using System;

class MaximalSumInArray
{
    static void Main()
    {
        Console.Write("Enter the array length: ");
        int n = int.Parse(Console.ReadLine());

        int[] array = new int[n];

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Enter array element {0}: ", i + 1);
            array[i] = int.Parse(Console.ReadLine());
        }

        int sum = 0;
        int biggestSum = 0;
        int startIndex = 0;
        int endIndex = 0;

        for (int i = 0; i < array.Length; i++)                   //Finding the biggest sum.
        {
            for (int j = i; j < array.Length; j++)
            {
                sum += array[j];
                if (sum > biggestSum)
                {
                    biggestSum = sum;
                    startIndex = i;
                    endIndex = j;
                }
            }
            sum = 0;
        }

        for (int i = 0; i < array.Length; i++)                   //Print one or more seqences equal to the biggest sum.
        {
            for (int j = i; j < array.Length; j++)
            {
                sum += array[j];
                if (sum == biggestSum)
                {
                    startIndex = i;
                    endIndex = j;
                    for (int k = startIndex; k <= endIndex; k++)
                    {
                        Console.Write("{0} ", array[k]);
                    }
                    Console.WriteLine();
                }  
            }
            sum = 0;
        }        
    }
}