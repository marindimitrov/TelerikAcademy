//Write a program that finds all prime numbers in the range [1...10 000 000]. 
//Use the sieve of Eratosthenes algorithm (find it in Wikipedia).

using System;

class SieveOfEratosthenes
{
    public static void Main()
    {
        int[] array = new int[10000000];

        for (int i = 0; i < 10000000; i++)
        {
            array[i] = i + 1;
        }

        for (int i = 1; i < 10000000; i++)                          
        {
                ExcludingNthNumber(array, i);                           //Method calls.
        }

        for (int i = 1; i < 10000000; i++)                              //Printing the result.
        {
            if (array[i] != 0)
            {
                Console.Write("{0} ", array[i]);
            }
        }
    }

    public static void ExcludingNthNumber(int[] array, int index)
    {
        if (array[index] != 0)
        {
            for (int i = 2 * array[index] - 1; i < 10000000; i += index + 1)
            {
                array[i] = 0;
            }   
        }
    }
}