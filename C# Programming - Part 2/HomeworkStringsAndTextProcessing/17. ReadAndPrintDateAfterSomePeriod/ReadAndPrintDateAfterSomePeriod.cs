////Write a program that reads a date and time given in the format: 
////day.month.year hour:minute:second and prints the date and time 
////after 6 hours and 30 minutes (in the same format) along with the 
////day of week in Bulgarian.

using System;
using System.Linq;
using System.Text;

class ReadAndPrintDateAfterSomePeriod
{
    static void Main()
    {
        Console.Write("Enter date and time in format described: ");
        string dateAsString = Console.ReadLine();

        DateTime inputDate = CreateDateTime(dateAsString);
        TimeSpan addition = new TimeSpan(6, 30, 0);
        DateTime dateAfterAddition = inputDate.Add(addition);

        Console.WriteLine(dateAfterAddition.ToString("dd.MM.yyyy HH:MM:ss dddd",
              System.Globalization.CultureInfo.CreateSpecificCulture("bg-BG")));
    }
    public static DateTime CreateDateTime(string dateAsString)
    {
        int firstDot = dateAsString.IndexOf('.');
        int secondDot = dateAsString.IndexOf('.', firstDot + 1);
        int interval = dateAsString.IndexOf(' ');
        int firstColon = dateAsString.IndexOf(':');
        int secondColon = dateAsString.IndexOf(':', firstColon + 1);

        StringBuilder dateBuilder = new StringBuilder();

        for (int i = 0; i < firstDot; i++)
        {
            dateBuilder.Append(dateAsString[i]);
        }
        int theDay = int.Parse(dateBuilder.ToString());
        dateBuilder.Clear();

        for (int i = firstDot + 1; i < secondDot; i++)
        {
            dateBuilder.Append(dateAsString[i]);
        }
        int theMonth = int.Parse(dateBuilder.ToString());
        dateBuilder.Clear();

        for (int i = secondDot + 1; i < interval; i++)
        {
            dateBuilder.Append(dateAsString[i]);
        }
        int theYear = int.Parse(dateBuilder.ToString());
        dateBuilder.Clear();

        for (int i = interval + 1; i < firstColon; i++)
        {
            dateBuilder.Append(dateAsString[i]);
        }
        int theHour = int.Parse(dateBuilder.ToString());
        dateBuilder.Clear();

        for (int i = firstColon + 1; i < secondColon; i++)
        {
            dateBuilder.Append(dateAsString[i]);
        }
        int theMinute = int.Parse(dateBuilder.ToString());
        dateBuilder.Clear();

        for (int i = secondColon + 1; i < dateAsString.Length; i++)
        {
            dateBuilder.Append(dateAsString[i]);
        }
        int theSecond = int.Parse(dateBuilder.ToString());
        dateBuilder.Clear();

        DateTime inputDate = new DateTime(theYear, theMonth, theDay, theHour, theMinute, theSecond);

        return inputDate;
    }
}