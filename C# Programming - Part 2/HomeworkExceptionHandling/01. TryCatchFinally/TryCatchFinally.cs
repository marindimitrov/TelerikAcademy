//Write a program that reads an integer number and calculates and prints its 
//square root. If the number is invalid or negative, print "Invalid number". 
//In all cases finally print "Good bye". Use try-catch-finally.

namespace TryCatchFinally
{
    using System;

    class TryCatchFinally
    {
        static void Main()
        {
            try
            {
                int number = int.Parse(Console.ReadLine());
                double sqrtOfNumber = Math.Sqrt(number);
                Console.WriteLine(sqrtOfNumber);
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Invalid number");
            }
            catch (System.OverflowException)
            {
                Console.WriteLine("The entered number is too big. Entered number should be up to {0}", Int32.MaxValue);
            }
            finally
            {
                Console.WriteLine("Good Bye");
            }
        }
    }
}