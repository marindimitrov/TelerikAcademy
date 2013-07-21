//Write a program that shows the sign (+ or -) of the 
//product of three real numbers without calculating it. 
//Use a sequence of if statements.

using System;

class SignOfProductOfThreeRealNumbers
{
    static void Main()
    {
        Console.WriteLine("Please enter three real numbers and check the sign of their product: ");
        double firstNum = double.Parse(Console.ReadLine());
        double secondNum = double.Parse(Console.ReadLine());
        double thirdNum = double.Parse(Console.ReadLine());
        if (firstNum > 0)
        {
            if (secondNum > 0)
            {
                if (thirdNum > 0)
                {
                    Console.WriteLine("The sign of the product is \"+\"");
                }
                else if (thirdNum < 0)
                {
                    Console.WriteLine("The sign of the product is \"-\"");
                }
                else
                {
                    Console.WriteLine("The product is \"0\"");
                }
            }
            else if (secondNum < 0)
            {
                if (thirdNum > 0)
                {
                    Console.WriteLine("The sign of the product is \"-\"");
                }
                else if (thirdNum < 0)
                {
                    Console.WriteLine("The sign of the product is \"+\"");
                }
                else
                {
                    Console.WriteLine("The product is \"0\"");
                }
            }
            else
            {
                Console.WriteLine("The product is \"0\"");
            }
        }
        else if (firstNum < 0)
        {
            if (secondNum > 0)
            {
                if (thirdNum > 0)
                {
                    Console.WriteLine("The sign of the product is \"-\"");
                }
                else if (thirdNum < 0)
                {
                    Console.WriteLine("The sign of the product is \"+\"");
                }
                else
                {
                    Console.WriteLine("The product is \"0\"");
                }
            }
            else if (secondNum < 0)
            {
                if (thirdNum > 0)
                {
                    Console.WriteLine("The sign of the product is \"+\"");
                }
                else if (thirdNum < 0)
                {
                    Console.WriteLine("The sign of the product is \"-\"");
                }
                else
                {
                    Console.WriteLine("The product is \"0\"");
                }
            }
            else
            {
                Console.WriteLine("The product is \"0\"");
            }
        }
        else
        {
            Console.WriteLine("The product is \"0\"");
        }
    }
}
