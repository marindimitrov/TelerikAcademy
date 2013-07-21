//We are given 5 integer numbers. Write a program 
//that checks if the sum of some subset of them is 0. 
//Example: 3, -2, 1, 1, 8 -> 1+1-2=0.

using System;

class CheckTheSumOfSubsetIsZero
{
    static void Main()
    {
        Console.WriteLine("This program will check if some of the subsets of 5 integer numbers is 0.");
        int[] numbersArr = new int[5];
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Enter an integer: ");
            numbersArr[i] = int.Parse(Console.ReadLine());
        }
        bool zeroSubset = false;
        for (int subset = 1; subset < 32; subset++)
        {
            int sum = 0;
            for (int position = 0; position < 5; position++)
            {
                bool equalToOne = (((subset >> position) & 1) == 1);
                if (equalToOne == true)
                {
                    sum += numbersArr[position];
                }
            }
            if (sum == 0)
            {
                zeroSubset = true;
            }
        }
        if (zeroSubset)
        {
            Console.WriteLine("There is at least one sum of subset which is equal to 0.");
        }
        else
        {
            Console.WriteLine("There is no sum of some subset which is equal to 0.");
        }
    }
}