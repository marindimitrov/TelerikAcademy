using System;

class ReadAndPrintMyAgeAfterTenYears
{
    static void Main()
    {
        Console.WriteLine("Please input your age and press Enter:");
        int myAge = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Your age after 10 years will be: " + (myAge + 10));
        Console.WriteLine(DateTime.Now.Year);
    }
}