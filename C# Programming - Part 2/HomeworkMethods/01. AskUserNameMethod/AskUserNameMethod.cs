//Write a method that asks the user for his name and 
//prints “Hello, <name>” (for example, “Hello, Peter!”). 
//Write a program to test this method.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class AskUserNameMethod
{
    static void Main()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        CatchName(name);
        PrintName(CatchName(name));
    }

    public static string CatchName(string name)
    {
        return name;
    }

    public static void PrintName(string name)
    {
        Console.WriteLine("Your name is: {0}", name);
    }
}