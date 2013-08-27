////Write a program to check if in a given expression the brackets are put correctly.
////Example of correct expression: ((a+b)/5-d).
////Example of incorrect expression: )(a+b)).

using System;

class CheckBracketsCorrectnessInExpression
{
    static void Main()
    {
        string inputExpression = "((a+b)/5-d)";

        int openBracketCount = 0;
        int closeBracketCount = 0;

        for (int i = 0; i < inputExpression.Length; i++)
        {
            if (inputExpression[i] == '(')
            {
                openBracketCount++;
            }
            else if (inputExpression[i] == ')')
            {
                closeBracketCount++;
            }
            if (closeBracketCount > openBracketCount)
            {
                throw new Exception("Incorrect expression, check close brackets!");
            }
        }
        if (openBracketCount != closeBracketCount)
        {
            throw new Exception("Incorrect expression, open brackets area more than close ones.");
        }
        Console.WriteLine("Correct expression: {0}", inputExpression);
    }
}