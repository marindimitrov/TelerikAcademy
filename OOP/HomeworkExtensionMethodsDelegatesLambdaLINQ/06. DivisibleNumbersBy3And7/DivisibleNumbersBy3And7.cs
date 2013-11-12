namespace DivisibleNumbersBy3And7
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    //Write a program that prints from given array of integers all numbers that are divisible by 7 
    //and 3. Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.

    class DivisibleNumbersBy3And7
    {
        static void Main()
        {
            int[] arr = new int[100];
            for (int i = 0; i < 100; i++)
            {
                arr[i] = i;
            }

            // Extension Methods and Lambda expressions
            IEnumerable<int> divisibleNumbers =
              arr.Where(num => (num % 3) == 0 && (num % 7) == 0).Select(num => num);
            foreach (var item in divisibleNumbers)
            {
                Console.WriteLine(item);
            }


            // LINQ
            var divisibleNumbersLinq =
                from a in arr
                where (a % 3 == 0) && (a % 7 == 0)
                select a;

            foreach (var num in divisibleNumbersLinq)
            {
                Console.WriteLine(num);
            }
        }
    }
}