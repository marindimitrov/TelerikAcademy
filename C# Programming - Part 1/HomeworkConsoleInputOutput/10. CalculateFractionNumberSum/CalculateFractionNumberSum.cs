//Write a program to calculate the sum (with accuracy 
//of 0.001): 1 + 1/2 - 1/3 + 1/4 - 1/5 + ...

using System;

class CalculateFractionNumberSum
{
    static void Main()
    {
        Console.Write("Enter the count of the members of the sequence: ");
        int countMembers = int.Parse(Console.ReadLine());
        float signedDenominator = 0.0f;
        float addend = 0.0f;
        float sum = 1.0f;

        for (int denominator = 2; denominator <= countMembers; denominator++)
        {
            if (denominator % 2 == 0)
            {
                signedDenominator = denominator;
            }
            else
            {
                signedDenominator = -denominator;
            }
            addend = (float)(1 / signedDenominator);
            sum = sum + addend;
        }
        Console.WriteLine("The sum of the first {0} members of the sequence is: {1:0.000}", 
            countMembers, Math.Round(sum, 3));
    }
}
