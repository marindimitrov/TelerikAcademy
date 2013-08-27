////Write a program for extracting all email addresses from given text. 
////All substrings that match the format <identifier>@<host>…<domain> 
////should be recognized as emails.

using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

class ExtractEmailAddressesFromText
{
    static void Main()
    {
        string textWithEmails = ReadInputText(@"..\text.txt");

        StringBuilder result = ExtractEmails(textWithEmails);

        Console.WriteLine(result);
    }
    public static string ReadInputText(string readedFilePath)
    {
        string textWithEmails = null;

        StreamReader reader = new StreamReader(readedFilePath);
        using (reader)
        {
            textWithEmails = reader.ReadToEnd();
        }
        return textWithEmails;
    }
    public static StringBuilder ExtractEmails(string textWithEmails)
    {
        Regex regexForEmails = new Regex(@"([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})",
            RegexOptions.IgnoreCase);

        MatchCollection emailMatches = regexForEmails.Matches(textWithEmails);

        StringBuilder result = new StringBuilder();

        foreach (Match emailMatch in emailMatches)
        {
            result.AppendLine(emailMatch.Value);
        }
        return result;
    }
}