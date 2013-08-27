////Modify the solution of the previous problem to replace only whole words (not substrings).

using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

class ReplaceStartWithFinish
{
    static void Main()
    {
        Encoding requiredEncoding = Encoding.GetEncoding("Windows-1251");

        StreamReader reader = new StreamReader(@"..\TextWithStart.txt", requiredEncoding);
        StreamWriter writer = new StreamWriter(@"..\TextWithFinish.txt");

        using (reader)
        {
            using (writer)
            {
                string readedTextRow = reader.ReadLine();

                while (readedTextRow != null)
                {
                    writer.WriteLine(Regex.Replace(readedTextRow, @"\bstart\b", "finish"));
                    readedTextRow = reader.ReadLine();
                }
            }
        }
    }
}