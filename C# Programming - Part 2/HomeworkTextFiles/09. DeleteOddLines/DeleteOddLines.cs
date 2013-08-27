////Write a program that deletes from given text file all odd lines. The result should be in the same file.

using System;
using System.IO;
using System.Linq;
using System.Text;

class DeleteOddLines
{
    static void Main()
    {
        Encoding requiredEncoding = Encoding.GetEncoding("Windows-1251");

        StringBuilder evenLines = new StringBuilder();

        StreamReader reader = new StreamReader(@"..\FullText_ResultOddLinesText.txt", requiredEncoding);
        using (reader)
        {
            string readedRowFromText = reader.ReadLine();
            readedRowFromText = reader.ReadLine();

            while (readedRowFromText != null)
            {
                evenLines.AppendLine(readedRowFromText);

                readedRowFromText = reader.ReadLine();
                readedRowFromText = reader.ReadLine();
            }
        }

        StreamWriter writer = new StreamWriter(@"..\FullText_ResultOddLinesText.txt");
        using (writer)
        {
            writer.Write(evenLines);
        }
    }
}