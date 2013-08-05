//Write a method that returns the index of the first element in array 
//that is bigger than its neighbors, or -1, if there’s no such element.
//Use the method from the previous exercise.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BiggerThanItsNeighboursElementIndex
{
    static void Main()
    {
        int[] array = new int[] { 4, 5, 6, 8, 9, 3, 6, 4, 3, 7, 8 };

        CheckAndReturn(array);
    }

    public static void CheckAndReturn(int[] inspectedArray)
    {
        if (inspectedArray[0] > inspectedArray[1])
        {
            Console.WriteLine("The number {0} (with index 0) is the first number in the array, bigger than its neighbours.",
                              inspectedArray[0]);
            return;
        }
        for (int i = 1; i < inspectedArray.Length - 1; i++)
        {
            if (inspectedArray[i] > inspectedArray[i - 1] && inspectedArray[i] > inspectedArray[i + 1])
            {
                Console.WriteLine("The number {0} (with index {1}) is the first number in the array, bigger than its neighbours.",
                                  inspectedArray[i], i);
                return;
            }
        }
        if (inspectedArray[inspectedArray.Length - 1] > inspectedArray[inspectedArray.Length - 2])
        {
            Console.WriteLine("The number {0} (with index {1}) is the first number in the array, bigger than its neighbours.",
                              inspectedArray[inspectedArray.Length - 1], inspectedArray.Length - 1);
            return;
        }
        else
        {
            Console.WriteLine("-1");
        }
    }
}