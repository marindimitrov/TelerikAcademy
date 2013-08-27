////Write a program that reads a text file and prints on the console its odd lines.
using System;
using System.IO;
using System.Text;

class PrintOddLinesFromTextFile
{
    public static void Main()
    {
        Encoding requiredEncoding = Encoding.GetEncoding("Windows-1251");

        StreamReader readMyFile = new StreamReader(@"../myfile.txt", requiredEncoding);

        using (readMyFile)
        {
            string readedText = readMyFile.ReadLine();

            while (readedText != string.Empty)
            {
                Console.WriteLine(readedText);
                readedText = readMyFile.ReadLine();
                readedText = readMyFile.ReadLine();
            }
        }
    }
}