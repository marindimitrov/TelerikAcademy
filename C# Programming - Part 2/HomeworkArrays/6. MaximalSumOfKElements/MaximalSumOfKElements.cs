//Write a program that reads two integer numbers N 
//and K and an array of N elements from the console. 
//Find in the array those K elements that have maximal sum.  

using System;

class MaximalSumOfKElements
{
    static void Main()
    {
        Console.Write("Enter the array length N: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter number K: ");
        int k = int.Parse(Console.ReadLine());

        int[] array = new int[n];

        for (int i = 0; i < array.Length; i++)                      //Entering the array elements.
        {
            Console.Write("Enter array element {0}: ", i + 1);
            array[i] = int.Parse(Console.ReadLine());
        }

        int biggest = 0;

        for (int i = 0; i < array.Length - 1; i++)                  //Finding the biggest element's index in array.
        {
            if (array[i] > array[i + 1] && array[i] > array[biggest])
            {
                biggest = i;
            }
            else if (array[i + 1] > array[biggest])
            {
                biggest = i + 1;
            }
        }

        Console.WriteLine(array[biggest]);

        int bigger = 0;

        for (int j = 1; j < k; j++)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (i != biggest)
                {
                    if (array[i] > array[i + 1] && array[i] <= array[biggest] && array[i] > array[bigger])
                    { 
                        bigger = i;
                    }
                    else if (array[i + 1] > array[i] && array[i + 1] <= array[biggest] && array[i] > array[bigger])
                    {
                        bigger = i + 1;
                    }
                }
            }
            Console.WriteLine(array[bigger]);
            biggest = bigger;
        }
    }
}