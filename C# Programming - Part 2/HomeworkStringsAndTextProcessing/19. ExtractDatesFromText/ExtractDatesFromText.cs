////Write a program that extracts from a given text all dates that match the 
////format DD.MM.YYYY. Display them in the standard date format for Canada.

using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

class ExtractDatesFromText
{
    static void Main()
    {
        string textWithDates = ReadInputText(@"..\text.txt");

        StringBuilder result = ExtractDates(textWithDates);

        Console.WriteLine(result);
    }
    public static string ReadInputText(string readedFilePath)
    {
        string textWithDates = null;

        StreamReader reader = new StreamReader(readedFilePath);
        using (reader)
        {
            textWithDates = reader.ReadToEnd();
        }
        return textWithDates;
    }
    public static StringBuilder ExtractDates(string textWithEmails)
    {
        Regex regexForDates = new Regex(@"\b\d{1,2}\.\d{1,2}.\d{4}\b",
            RegexOptions.IgnoreCase);

        MatchCollection datesMatches = regexForDates.Matches(textWithEmails);

        StringBuilder result = new StringBuilder();

        foreach (Match dateMatch in datesMatches)
        {
            result.AppendLine(dateMatch.Value);
        }
        return result;
    }
}