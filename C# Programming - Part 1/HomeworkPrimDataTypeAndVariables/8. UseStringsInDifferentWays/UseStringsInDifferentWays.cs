using System;

class UseStringsInDifferentWays
{
    static void Main()
    {
        string quotedString = "The \"use\" of quotations causes difficulties.";
        string atQuotedString = @"The ""use"" of quotations causes difficulties.";
        Console.WriteLine(quotedString);
        Console.WriteLine(atQuotedString);
    }
}
