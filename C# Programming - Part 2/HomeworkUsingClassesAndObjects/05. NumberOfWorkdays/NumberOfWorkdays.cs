//Write a method that calculates the number of workdays between today and given 
//date, passed as parameter. Consider that workdays are all days from Monday to 
//Friday except a fixed list of public holidays specified preliminary as array.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class NumberOfWorkdays
{
    static void Main()
    {
        Console.WriteLine("Enter required date: day, month, year, each followed by Enter:");
        int day = int.Parse(Console.ReadLine());
        int month = int.Parse(Console.ReadLine());
        int year = int.Parse(Console.ReadLine());

        DateTime todaysDate = DateTime.Today;
        DateTime todaysDateOnly = todaysDate.Date;
        DateTime futureDate = new DateTime(year, month, day);
        DateTime futureDateOnly = futureDate.Date;

        TimeSpan period = futureDateOnly.Subtract(todaysDateOnly);

        string periodAsString = period.ToString();
        int clearAfterThisIndex = periodAsString.IndexOf(".");
        if (clearAfterThisIndex > 0)
        {
            periodAsString = periodAsString.Substring(0, clearAfterThisIndex);
        }
        int totalDaysInPeriod = int.Parse(periodAsString);

        DateTime[] holidays = new DateTime[]
        {
            new DateTime(2013, 9, 6),
            new DateTime(2013, 12, 24),
            new DateTime(2013, 12, 25),
            new DateTime(2013, 12, 26),
            new DateTime(2013, 12, 31)
        };

        int weekendDayCounter = 0;
        int holidayCounter = 0;
        for (int i = 0; i < totalDaysInPeriod; i++)
        {
            if (todaysDate.AddDays(i + 1).DayOfWeek == DayOfWeek.Saturday || todaysDate.AddDays(i + 1).DayOfWeek == DayOfWeek.Sunday)
            {
                weekendDayCounter++;
            }

            for (int j = 0; j < holidays.Length; j++)
            {
                if (todaysDate.AddDays(i + 1) == holidays[j])
                {
                    holidayCounter++;
                }
            }
        }
       
        int workingDays = totalDaysInPeriod - (weekendDayCounter + holidayCounter);
        Console.Write("Working days between today(incl.) and {0}(incl.) are ", futureDate.ToString("d"));
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Write("{0}", workingDays);
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine(".");
    }
}