//Write a program that reads two numbers N and K and generates all the variations of 
//K elements from the set [1..N]. Example:
//N = 3, K = 2  {1, 1}, {1, 2}, {1, 3}, {2, 1}, {2, 2}, {2, 3}, {3, 1}, {3, 2}, {3, 3}

using System;

class VariationsOfKElements
{
    static int n;
    static int k;

    static int[] currentArray;

    static void Main()
    {
        Console.Write("Enter N = ");
        n = int.Parse(Console.ReadLine());

        Console.Write("Enter K = ");
        k = int.Parse(Console.ReadLine());

        currentArray = new int[k];

        ArrayVariations(0);
    }

    static void ArrayVariations(int currentVariation)   //Method using recursion.
    {
        if (currentVariation == k)
        {
            PrintArray();
            return;
        }
        for (int currentArrayElement = 1; currentArrayElement <= n; currentArrayElement++)
        {
            currentArray[currentVariation] = currentArrayElement;
            ArrayVariations(currentVariation + 1);
        }
    }

    static void PrintArray()                            //Used to print the result.
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