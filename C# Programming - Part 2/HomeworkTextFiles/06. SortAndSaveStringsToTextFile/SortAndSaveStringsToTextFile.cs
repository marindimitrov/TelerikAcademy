////Write a program that reads a text file containing a list of strings, 
////sorts them and saves them to another text file. Example:
////    Ivan			George
////    Peter			Ivan
////    Maria			Maria
////    George			Peter

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class SortAndSaveStringsToTextFile
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"..\Unsorted File.txt");

        using (reader)
        {
            List<string> listOfStrings = new List<string>();

            string eachLine = reader.ReadLine();

            while (eachLine != null)
            {
                listOfStrings.Add(eachLine);
                eachLine = reader.ReadLine();
            }

            listOfStrings.Sort();

            StreamWriter writer = new StreamWriter(@"..\Sorted File.txt");
            using (writer)
            {
                string usedLineString = string.Empty;
                foreach (var stringLine in listOfStrings)
                {
                    usedLineString = stringLine;
                    writer.WriteLine(usedLineString);
                }
            }
        }
    }
}