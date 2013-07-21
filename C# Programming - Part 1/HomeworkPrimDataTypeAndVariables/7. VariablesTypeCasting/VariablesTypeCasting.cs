using System;

class VariablesTypeCasting
{
    static void Main()
    {
        string firstWord = "Hello ";
        string secondWord = "World!";
        object wordConcatenation = firstWord + secondWord;
        string typeCasting = (string)wordConcatenation;
        Console.WriteLine(typeCasting);
    }
}
