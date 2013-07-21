//Sorting an array means to arrange its elements in 
//increasing order. Write a program to sort an array. 
//Use the "selection sort" algorithm: Find the smallest 
//element, move it at the first position, find the smallest 
//from the rest, move it at the second position, etc.

using System;

class SortingAnArray
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

        int temp = 0;

        for (int iteration = 0; iteration < n; iteration++)     //Number of iterations is equal to the number of elements.
        {
            for (int i = iteration; i < array.Length; i++)      //Finding smallest one and moving it to the left side.
            {
                if (array[i] < array[iteration])
                {
                    temp = array[iteration];
                    array[iteration] = array[i];
                    array[i] = temp;
                }
            }
        }

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("{0} ", array[i]);
        }
        Console.WriteLine();
    }
}