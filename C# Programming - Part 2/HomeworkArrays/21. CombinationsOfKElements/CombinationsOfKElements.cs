//Write a program that reads two numbers N and K and generates all the combinations 
//of K distinct elements from the set [1..N]. 
//Example: N = 5, K = 2  {1, 2}, {1, 3}, {1, 4}, {1, 5}, {2, 3}, {2, 4}, {2, 5}, {3, 4}, {3, 5}, {4, 5}

using System;

class CombinationsOfKElements
{
    static int n;
    static int k;
    
    //This variable is for the first element in every single array with combination.
    static int startingNumberInCurrentArray = 1;

    static int[] currentArray;

    static void Main()
    {
        Console.Write("Enter N = ");
        n = int.Parse(Console.ReadLine());

        Console.Write("Enter K = ");
        k = int.Parse(Console.ReadLine());

        currentArray = new int[k];

        ArrayCombinations(0, 0);
    }

    //Current combination with recursion.
    //"additionToNextElementInArray" is for next element in the current combination.
    //Every next element in the combination rises faster that every previuos element in array.
    static void ArrayCombinations(int currentCombination, int additionToNextElementInArray)
    {
        if (currentCombination == k)
        {
            PrintArray();
            return;
        }

        for (int arrayElement = startingNumberInCurrentArray + additionToNextElementInArray; arrayElement <= n; arrayElement++)
        {
            currentArray[currentCombination] = arrayElement;

            ArrayCombinations(currentCombination + 1, additionToNextElementInArray + 1);
        }
        startingNumberInCurrentArray++;
    }

    //Printing current combination.
    static void PrintArray()
    {
        for (int i = 0; i < k; i++)
        {
            if (i == 0)
            {
                Console.Write("{{{0}, ", currentArray[i]);
            }
            else if (i == k - 1)
            {
                Console.Write("{0}}}", currentArray[i]);
            }
            else
            {
                Console.Write("{0}, ", currentArray[i]);
            }
        }
        Console.WriteLine();
    }
}