//  Write a program that can solve these tasks:
//      - Reverses the digits of a number
//      - Calculates the average of a sequence of integers
//      - Solves a linear equation a * x + b = 0
//  Create appropriate methods.
//  Provide a simple text-based menu for the user to choose which task to solve.
//  Validate the input data:
//      - The decimal number should be non-negative
//      - The sequence should not be empty
//      - a should not be equal to 0

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class TasksSolving
{
    static void Main()
    {
        Console.WriteLine("Please choose what to do: ");
        Console.WriteLine("Choose \"1\", if you want to reverse digits of a number.");
        Console.WriteLine("Choose \"2\", if you want to calculates the average of a sequence of integers");
        Console.WriteLine("Choose \"3\", if you want to solve a linear equation a * x + b = 0");
        Console.WriteLine("Enter \"0\" for exit.");

        int choice = -1;
        while (choice < 0 || choice > 3)
        {
            Console.Write("Please choose between 1, 2, 3 or 0 (zero for exit): ");
            choice = int.Parse(Console.ReadLine());
        }

        switch (choice)
        {
            case 1: ReverseDigitsOfNumber();
                break;
            case 2: CalculateAverageOfIntegers();
                break;
            case 3: SolveLinearEquation();
                break;
            case 0: return;
                break;
        }
    }

    public static void ReverseDigitsOfNumber()
    {
        int number = -1;
        while (number < 0)
        {
            Console.Write("Please enter non negative number: ");
            number = int.Parse(Console.ReadLine());
        }

        Console.Write("The number with reversed digits is: ");

        string numberAsString = number.ToString();
        char[] reversedNumber = numberAsString.ToCharArray();

        for (int i = 0, j = numberAsString.Length - 1; i < numberAsString.Length; i++, j--)
        {
            reversedNumber[j] = numberAsString[i];
        }

        for (int i = 0; i < reversedNumber.Length; i++)
        {
            Console.Write(reversedNumber[i]);
        }
        Console.WriteLine();
    }

    public static void CalculateAverageOfIntegers()
    {
        Console.WriteLine("Enter number of integers, you want to averaging: ");
        int numberOfIntegers = 0;
        while (numberOfIntegers < 1)
        {
            Console.Write("Please enter et least one: ");
            numberOfIntegers = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Please enter a sequence of integers: ");
        List<int> listOfIntegers = new List<int>();

        for (int i = 0; i < numberOfIntegers; i++)
        {
            listOfIntegers.Add(int.Parse(Console.ReadLine()));
        }

        double average = 0;
        for (int i = 0; i < listOfIntegers.Count; i++)
        {
            average += listOfIntegers[i];
        }
        average /= numberOfIntegers;

        Console.WriteLine("The average of the input sequence is: {0}", average);
    }

    public static void SolveLinearEquation()
    {
        Console.WriteLine("You are about to solve equation a * x + b = 0.");
        decimal a = 0;
        while (a == 0)
        {
            Console.Write("Please enter \"a\" (different from zero): ");
            a = decimal.Parse(Console.ReadLine());
        }
        Console.Write("Enter \"b\": ");
        decimal b = decimal.Parse(Console.ReadLine());
        decimal x = -b / a;
        Console.Write("The result of the equation is: {0}", x);
        Console.WriteLine();
    }
}