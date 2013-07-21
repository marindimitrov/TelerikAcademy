//Write a program that, depending on the user's 
//choice inputs int, double or string variable. If the 
//variable is integer or double, increases it with 1. If 
//the variable is string, appends "*" at its end. The 
//program must show the value of that variable as a 
//console output. Use switch statement.

using System;

class ShowValueOfOutputVariable
{
    static void Main()
    {
        Console.Write("Please enter desired variable: 1 - Integer, 2 - Double, 3 - String: ");
        byte desiredVar = byte.Parse(Console.ReadLine());
        switch (desiredVar)
        {
            case 1:
                Console.Write("Enter an Integer: ");
                int varInt = int.Parse(Console.ReadLine());
                Console.WriteLine("The output variable is: {0}", varInt + 1);
                break;
            case 2:
                Console.Write("Enter a Double: ");
                double varDouble = double.Parse(Console.ReadLine());
                Console.WriteLine("The output variable is {0}", varDouble + 1.0);
                break;
            case 3:
                Console.Write("Enter a string: ");
                string varString = Console.ReadLine();
                Console.WriteLine("The output variable is {0}", varString + "*");
                break;
            default: 
                Console.WriteLine("Please enter 1, 2 or 3 as your choice.");
                break;
        }
    }
}