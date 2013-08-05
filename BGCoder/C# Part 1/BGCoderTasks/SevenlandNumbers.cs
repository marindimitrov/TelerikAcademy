using System;

class SevenlandNumbers
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        if (number >= 0 && number <= 65)
        {
            if ((number % 10) < 6)
            {
                number += 1;
            }
            else if ((number % 10) == 6)
            {
                number += 4;
            }
        }

        else if (number == 66)
        {
            number = 100;
        }

        else if (number >= 100 && number < 666)
        {
            if ((number/10) % 10 < 6)
            {
                if (number % 10 < 6 )
                {
                    number += 1;
                }
                if (number % 10 == 6)
                {
                    number += 4;
                }
            }
            if ((number / 10) % 10 == 6)
            {
                if (number % 10 < 6)
                {
                    number += 1;
                }
                if (number % 10 == 6)
                {
                    number += 34; 
                }
            }
        }
        else if (number == 666)
        {
            number = 1000;
        }
        Console.WriteLine(number);
    }
}