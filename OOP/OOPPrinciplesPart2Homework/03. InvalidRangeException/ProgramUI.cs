using System;
using System.Linq;

namespace InvalidRangeExceptions
{
    class ProgramUI
    {
        static void Main()
        {
            ThrowNumberException();

            ThrowDateTimeException();
        }

        public static void ThrowNumberException()
        {
            int number = int.Parse(Console.ReadLine());
            int minValue = 1;
            int maxValue = 100;

            if (number > minValue && number < maxValue)
            {
                Console.WriteLine("You entered a correct number");
            }
            else
            {
                throw new InvalidRangeException<int>("Exception occured", minValue, maxValue);
            }
        }

        public static void ThrowDateTimeException()
        {
            DateTime minValue = new DateTime(1980, 1, 1);
            DateTime maxValue = new DateTime(2013, 12, 31);
            DateTime myDate = DateTime.Parse(Console.ReadLine());

            if (myDate.Year < 1980 && myDate.Month > 1 && myDate.Day > 1)
            {
                throw new InvalidRangeException<DateTime>("Exception occured", minValue, maxValue);
            }
            else
            {
                Console.WriteLine("You entered a correct date");
            }
        }
    }
}