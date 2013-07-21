//Sort 3 real values in descending order using nested if statements.

using System;

class SortValuesInDescendingOrder
{
    static void Main()
    {
        Console.WriteLine("This program sorts 3 real values in descending order.\n");
        Console.Write("Enter number \"a\": ");
        float a = float.Parse(Console.ReadLine());
        Console.Write("Enter number \"b\": ");
        float b = float.Parse(Console.ReadLine());
        Console.Write("Enter number \"c\": ");
        float c = float.Parse(Console.ReadLine());

        if (a > b)
        {
            if (a > c)
            {
                if (b >= c)
                {
                    Console.WriteLine("\n{0} {1} {2}\n", a, b, c);
                }
                else if (b < c)
                {
                    Console.WriteLine("\n{0} {1} {2}\n", a, c, b);
                }
            }
            else if (a < c)
            {
                Console.WriteLine("\n{0} {1} {2}\n", c, a, b);
            }
            else
            {
                Console.WriteLine("\n{0} {1} {2}\n", a, c, b);
            }
        }
        else if (a < b)
        {
            if (a > c)
            {
                Console.WriteLine("\n{0} {1} {2}\n", b, a, c);
            }
            else if (a < c)
            {
                if (b >= c)
                {
                    Console.WriteLine("\n{0} {1} {2}\n", b, c, a);
                }
                else if (b < c)
                {
                    Console.WriteLine("\n{0} {1} {2}\n", c, b, a);
                }
            }
            else
            {
                Console.WriteLine("\n{0} {1} {2}\n", b, a, c);
            }
        }
        else
        {
            if (a > c)
            {
                Console.WriteLine("\n{0} {1} {2}\n", a, b, c);
            }
            else if (a < c)
            {
                Console.WriteLine("\n{0} {1} {2}\n", c, a, b);
            }
            else
            {
                Console.WriteLine("\n{0} {1} {2}\n", a, b, c);
            }
        }
    }
}