//Write a program that reads two arrays from the 
//console and compares them element by element.

using System;

class CompareTwoArrays
{
    static void Main()
    {
        Console.Write("Please enter the size of the arrays: ");
        int arraysLength = int.Parse(Console.ReadLine());

        int[] firstArray = new int[arraysLength];
        int[] secondArray = new int[arraysLength];

        for (int i = 0; i < firstArray.Length; i++)
        {
            Console.WriteLine("Enter element No:{0} of the first array", i);
            firstArray[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < secondArray.Length; i++)
        {
            Console.WriteLine("Enter element No:{0} of the second array", i);
            secondArray[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < arraysLength; i++)
        {
            if (firstArray[i] > secondArray[i])
            {
                Console.WriteLine("Element No:{0} of the first array is bigger than element No:{0} of the second array.", i);
            }
            else if (firstArray[i] < secondArray[i])
            {
                Console.WriteLine("Element No:{0} of the first array is less than element No:{0} of the second array.", i);
            }
            else if (firstArray[i] == secondArray[i])
            {
                Console.WriteLine("Element No:{0} of the first array is equal to element No:{0} of the second array.", i);
            }
        }
    }
}