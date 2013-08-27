////Write a program that replaces all occurrences of the substring "start" with the substring 
////"finish" in a text file. Ensure it will work with large files (e.g. 100 MB).

using System;
using System.IO;
using System.Text;

class ReplaceStartWithFinish
{
    static void Main()
    {
        Encoding requiredEncoding = Encoding.GetEncoding("Windows-1251");

        StreamReader reader = new StreamReader(@"..\Text.txt", requiredEncoding);
        StreamWriter writer = new StreamWriter(@"..\ChangedText.txt");

        string readedTextRow = reader.ReadLine();

        using (writer)
        {
            using (reader)
            {
                while (readedTextRow != null)
                {
                    readedTextRow = readedTextRow.Replace("start", "finish");
                    writer.WriteLine(readedTextRow);
                    readedTextRow = reader.ReadLine();
                }
            }
        }
    }
}