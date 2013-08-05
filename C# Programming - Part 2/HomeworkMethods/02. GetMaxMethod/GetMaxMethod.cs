//Write a method GetMax() with two parameters that 
//returns the bigger of two integers. Write a program 
//that reads 3 integers from the console and prints the 
//biggest of them using the method GetMax().

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class GetMaxMethod
{
    public static void Main()
    {
        Console.WriteLine("Please enter three numbers, each on a single line:");
        int firstNum = int.Parse(Console.ReadLine());
        int secondNum = int.Parse(Console.ReadLine());
        int thirdNum = int.Parse(Console.ReadLine());

        GetMax(firstNum, secondNum);

        Console.Write("The biggest of the three numbers is: ");
        Console.WriteLine(GetMax(GetMax(firstNum, secondNum), thirdNum));
    }

    public static int GetMax(int a, int b)
    {
        if (a > b)
        {
            return a;
        }
        if (a < b)
        {
            return b;
        }
        else
        {
            return a;
        }
    }
}