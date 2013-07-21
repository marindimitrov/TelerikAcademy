using System;

class SafeCompareFloatNum
{
    static void Main()
    {
        Console.WriteLine("This program compares float numbers ->");
        Console.WriteLine();
        Console.Write("Please input the first compare number: ");
        float firstCompareNum = float.Parse(Console.ReadLine());
        Console.Write("Please input the second compare number: ");
        float secondCompareNum = float.Parse(Console.ReadLine());
        Console.Write("The compare numbers are equal -> ");
        bool resultCompareNum = firstCompareNum == secondCompareNum;
        Console.WriteLine(resultCompareNum);
    }
}