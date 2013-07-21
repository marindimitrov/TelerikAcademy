//Write a program that finds the index of given element 
//in a sorted array of integers by using the binary 
//search algorithm (find it in Wikipedia).

using System;

class FindingElementIndex
{
    static void Main()
    {
        Console.Write("Enter the array length: ");
        int n = int.Parse(Console.ReadLine());

        int[] array = new int[n];

        Console.WriteLine("Enter {0} different array elements:", n);
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Enter searched element (should be equal to some of the array's elements): ");
        int searchedNum = int.Parse(Console.ReadLine());

        int temp = 0;

        for (int iteration = 0; iteration < n; iteration++)     //Sorting the array, if it isn't sorted.
        {
            for (int i = iteration; i < array.Length; i++)
            {
                if (array[i] < array[iteration])
                {
                    temp = array[iteration];
                    array[iteration] = array[i];
                    array[i] = temp;
                }
            }
        }

        int small = 0;
        int big = array.Length - 1;
        int middle = (big - small) / 2;
        int searchedIndex = 0;

        while (array[middle] != searchedNum)                    //Finding the searched index.
        {
            if (searchedNum > array[small + (big - small) / 2])
            {
                small = middle;
                middle = small + (big - small) / 2;
            }
            else if (searchedNum < array[small + (big - small) / 2])
            {
                big = middle;
                middle = small + (big - small) / 2;
            }
        }
        searchedIndex = middle;

        Console.WriteLine("The searched index of the element \"{0}\" is \"{1}\".", searchedNum, searchedIndex);
    }
}