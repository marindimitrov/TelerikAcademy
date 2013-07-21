//Write a program that finds in given array of integers 
//a sequence of given sum S (if present). 
//Example: {4, 3, 1, 4, 2, 5, 8}, S=11  {4, 2, 5}

using System;

class FindingSequenceGivingSumS
{
    static void Main()
    {
        Console.Write("Enter the array length: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter required sum S: ");
        int s = int.Parse(Console.ReadLine());

        int[] array = new int[n];

        for (int el = 0; el < array.Length; el++)
        {
            Console.Write("Enter array element {0}: ", el + 1);
            array[el] = int.Parse(Console.ReadLine());
        }

        int sum = 0;
        int startIndex = 0;
        int endIndex = 0;

        for (int i = 0; i < array.Length; i++)                                              //Finding the sequence with sum equal to S.
        {
            for (int j = i; j < array.Length; j++)
            {
                sum += array[j];
                if (sum == s)
                {
                    startIndex = i;
                    endIndex = j;

                    Console.Write("Sequence with sum equal to {0}: ", s);
                    for (int printIndex = startIndex; printIndex <= endIndex; printIndex++) //Printing the sequence, which sum is equal to S.
                    {
                        Console.Write("{0} ", array[printIndex]);
                    }
                    Console.WriteLine();
                }
            }
            sum = 0;
        }
    }
}