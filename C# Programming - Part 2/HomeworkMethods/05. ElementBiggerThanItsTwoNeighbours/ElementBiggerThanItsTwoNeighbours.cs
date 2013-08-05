//Write a method that checks if the element at given position in given 
//array of integers is bigger than its two neighbors (when such exist).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ElementBiggerThanItsTwoNeighbours
{
    static void Main()
    {
        int[] inspectedArray = new int[] { 6, 5, 9, 7, 0, 9, 1, 1, 2, 7, 5, 8, 10 };

        Check(inspectedArray);
    }

    public static void Check(int[] inspectedArray)
    {
        if (inspectedArray[0] > inspectedArray[1])
        {
            Console.WriteLine("The number {0} (with index 0) is bigger than its neighbours.",
                              inspectedArray[0]);
        }
        for (int i = 1; i < inspectedArray.Length - 1; i++)
        {
            if (inspectedArray[i] > inspectedArray[i - 1] && inspectedArray[i] > inspectedArray[i + 1])
            {
                Console.WriteLine("The number {0} (with index {1}) is bigger than its neighbours.",
                                  inspectedArray[i], i);
            }
        }
        if (inspectedArray[inspectedArray.Length - 1] > inspectedArray[inspectedArray.Length - 2])
        {
            Console.WriteLine("The number {0} (with index {1}) is bigger than its neighbours.",
                              inspectedArray[inspectedArray.Length - 1], inspectedArray.Length - 1);
        }
    }
}