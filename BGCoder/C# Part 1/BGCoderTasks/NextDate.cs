using System;

class NextDate
{
    static void Main()
    {
        int day = int.Parse(Console.ReadLine());
        int month = int.Parse(Console.ReadLine());
        int year = int.Parse(Console.ReadLine());

        int nextDay = 0;
        int nextMonth = 0;
        int nextYear = 0;

        if (1 <= day && day <= 31 && 1 <= month && month <= 12 && 2000 <= year && year <= 2013)
        {
            if (year == 2000 || year == 2004 || year == 2008 || year == 2012)
            {
                if (month == 2 && day < 28)
                {
                    nextDay = day + 1;
                    nextMonth = month;
                    nextYear = year;
                }
                else if (month == 2 && day == 28)
                {
                    nextDay = 1;
                    nextMonth = month + 1;
                    nextYear = year;
                }
                else if ((month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12) && day < 31)
                {
                    nextDay = day + 1;
                    nextMonth = month;
                    nextYear = year;
                }
                else if ((month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10) && day == 31)
                {
                    nextDay = 1;
                    nextMonth = month + 1;
                    nextYear = year;
                }
                else if (month == 12 && day == 31)
                {
                    nextDay = 1;
                    nextMonth = 1;
                    nextYear = year + 1;
                }
                else if ((month == 4 || month == 6 || month == 9 || month == 11) && day < 30)
                {
                    nextDay = day + 1;
                    nextMonth = month;
                    nextYear = year;
                }
                else if ((month == 4 || month == 6 || month == 9 || month == 11) && day == 30)
                {
                    nextDay = 1;
                    nextMonth = month + 1;
                    nextYear = year;
                }
                else
                {
                    Console.WriteLine("The input values are out of date range.");
                    return;
                }
            }
            else
            {
                if (month == 2 && day < 29)
                {
                    nextDay = day + 1;
                    nextMonth = month;
                    nextYear = year;
                }
                if (month == 2 && day == 29)
                {
                    nextDay = 1;
                    nextMonth = month + 1;
                    nextYear = year;
                }
                else if ((month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10) && day < 31)
                {
                    nextDay = day + 1;
                    nextMonth = month;
                    nextYear = year;
                }
                else if ((month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10) && day == 31)
                {
                    nextDay = 1;
                    nextMonth = month + 1;
                    nextYear = year;
                }
                else if (month == 12 && day == 31)
                {
                    nextDay = 1;
                    nextMonth = 1;
                    nextYear = year + 1;
                }
                else if ((month == 4 || month == 6 || month == 9 || month == 11) && day < 30)
                {
                    nextDay = day + 1;
                    nextMonth = month;
                    nextYear = year;
                }
                else if ((month == 4 || month == 6 || month == 9 || month == 11) && day == 30)
                {
                    nextDay = 1;
                    nextMonth = month + 1;
                    nextYear = year;
                }
                else
                {
                    Console.WriteLine("The input values are out of date range.");
                    return;
                }
            }
            Console.WriteLine("{0}.{1}.{2}", nextDay, nextMonth, nextYear);
        }
        else
        {
            Console.WriteLine("The input values are out of date range.");
        }
    }
}