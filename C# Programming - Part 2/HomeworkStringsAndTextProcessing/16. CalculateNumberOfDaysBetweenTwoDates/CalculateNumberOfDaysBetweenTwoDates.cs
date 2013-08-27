////Write a program that reads two dates in the format: day.month.year 
////and calculates the number of days between them. Example:
////    Enter the first date: 27.02.2006
////    Enter the second date: 3.03.2004
////    Distance: 4 days

using System;
using System.Linq;
using System.Text;

class CalculateNumberOfDaysBetweenTwoDates
{
    static void Main()
    {
        Console.Write("Enter first date: ");
        string firstDateAsString = Console.ReadLine();

        Console.Write("Enter second date: ");
        string secondDateAsString = Console.ReadLine();

        DateTime firstDate = CalculateDate(firstDateAsString);
        DateTime secondDate = CalculateDate(secondDateAsString);

        int distance = CalculateDistance(firstDate, secondDate);
        Console.WriteLine("Distance: {0} days", distance);
    }
    public static DateTime CalculateDate(string dateAsString)
    {
        StringBuilder dateBuilder = new StringBuilder();

        int firstDot = dateAsString.IndexOf('.');
        int secondDot = dateAsString.IndexOf('.', firstDot + 1);

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

        for (int i = secondDot + 1; i < dateAsString.Length; i++)
        {
            dateBuilder.Append(dateAsString[i]);
        }
        int theYear = int.Parse(dateBuilder.ToString());
        dateBuilder.Clear();

        DateTime date = new DateTime(theYear, theMonth, theDay);

        return date;
    }
    public static int CalculateDistance(DateTime firstDate, DateTime secondDate)
    {
        StringBuilder dateBuilder = new StringBuilder();

        TimeSpan period = firstDate.Date.Subtract(secondDate.Date);
        string periodAsString = period.ToString();

        int printToIndex = periodAsString.IndexOf('.');
        for (int i = 0; i < printToIndex; i++)
        {
            dateBuilder.Append(periodAsString[i]);
        }

        int distance = Math.Abs((int.Parse(dateBuilder.ToString())));

        return distance;
    }
}