////Write a program that compares two text files line by line and prints 
////the number of lines that are the same and the number of lines that 
////are different. Assume the files have equal number of lines.

using System;
using System.IO;

class SameAndDifferentLinesInComparedTexts
{
    static void Main()
    {
        StreamReader firstReader = new StreamReader(@"..\FirstText.txt");
        using (firstReader)
        {
            StreamReader secondReader = new StreamReader(@"..\SecondText.txt");
            using (secondReader)
            {
                string firstString = firstReader.ReadLine();
                string secondString = secondReader.ReadLine();

                int numberOfSameLines = 0;
                int numberOfDifferentLines = 0;

                while (firstString != null)
                {
                    if (firstString == secondString)
                    {
                        numberOfSameLines++;
                    }
                    if (firstString != secondString)
                    {
                        numberOfDifferentLines++;
                    }
                    firstString = firstReader.ReadLine();
                    secondString = secondReader.ReadLine();
                }
                Console.WriteLine("Same lines are {0}, and different lines are {1}", numberOfSameLines, numberOfDifferentLines);
            }
        }
    }
}