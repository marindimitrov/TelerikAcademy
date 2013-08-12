//Write a method ReadNumber(int start, int end) that enters an integer number in given range [start…end]. 
//If an invalid number or non-number text is entered, the method should throw an exception. 
//Using this method write a program that enters 10 numbers:
//    a1, a2, … a10, such that 1 < a1 < … < a10 < 100

namespace ThrowException
{
    using System;

    class ThrowException
    {
        static int ReadNumber(int start, int end)
        {
            Console.WriteLine("Enter number in range {0}~{1}", start, end);
            int input = int.Parse(Console.ReadLine());
            if (input < start || input > end)
            {
                throw new Exception("The number you entered is out of the required range");
            }
            return input;
        }
        static void Main()
        {
            int[] number = new int[10];
            number[0] = ReadNumber(1, 100);
            for (int i = 1; i < 10; i++)
            {
                number[i] = ReadNumber(1, 100);
                if (number[i] <= number[i - 1])
                {
                    Console.WriteLine("Entered number is not bigger than previous one. Please enter another number bigger than {0}", number[i - 1]);
                    i--;
                }
            }
        }
    }
}