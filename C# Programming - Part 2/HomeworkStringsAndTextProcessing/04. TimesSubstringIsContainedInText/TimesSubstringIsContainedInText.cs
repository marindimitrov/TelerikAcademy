////Write a program that finds how many times a substring is contained 
////in a given text (perform case insensitive search).
////
////    Example: The target substring is "in". The text is as follows:
////
////        We are living in an yellow submarine. We don't have anything else. 
////        Inside the submarine is very tight. So we are drinking all the day. 
////        We will move out of it in 5 days.
////
////    The result is: 9.

using System;
using System.IO;
using System.Linq;

class TimesSubstringIsContainedInText
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"..\text.txt");
        using (reader)
        {
            string readedText = reader.ReadToEnd().ToLower();
            char[] textAsCharArray = readedText.ToCharArray();
            int substringCount = 0;
            for (int i = 0; i < textAsCharArray.Length - 1; i++)
            {
                if (textAsCharArray[i] == 'i' && textAsCharArray[i + 1] == 'n')
                {
                    substringCount++;
                }
            }
            Console.WriteLine("The result is: {0}.", substringCount);
        }
    }
}