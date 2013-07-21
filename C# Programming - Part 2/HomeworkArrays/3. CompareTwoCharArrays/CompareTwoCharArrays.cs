//Write a program that compares two char arrays 
//lexicographically (letter by letter).

using System;

class CompareTwoCharArrays
{
    static void Main()
    {
        Console.Write("Please enter the size of the arrays: ");
        int arraysLength = int.Parse(Console.ReadLine());

        char[] firstArray = new char[arraysLength];
        char[] secondArray = new char[arraysLength];

        for (int i = 0; i < firstArray.Length; i++)
        {
            Console.WriteLine("Enter char No:{0} of the first array", i);
            firstArray[i] = char.Parse(Console.ReadLine());
        }
        for (int i = 0; i < secondArray.Length; i++)
        {
            Console.WriteLine("Enter char No:{0} of the second array", i);
            secondArray[i] = char.Parse(Console.ReadLine());
        }

        for (int i = 0; i < arraysLength; i++)
        {
            if (firstArray[i] > secondArray[i])
            {
                Console.WriteLine("Char No:{0} of the first array is before char No:{0} of the second array.", i);
            }
            else if (firstArray[i] < secondArray[i])
            {
                Console.WriteLine("Char No:{0} of the first array is after char No:{0} of the second array.", i);
            }
            else if (firstArray[i] == secondArray[i])
            {
                Console.WriteLine("Char No:{0} of the first array is the same as char No:{0} of the second array.", i);
            }
        }
    }
}