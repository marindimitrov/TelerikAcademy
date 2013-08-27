////Write a program that deletes from a text file all words that start with the prefix "test". 
////Words contain only the symbols 0...9, a...z, A…Z, _.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class DeleteWordsWithPrefixTest
{
    static void Main()
    {
        Encoding requiredEncoding = Encoding.GetEncoding("Windows-1251");

        StreamReader reader = new StreamReader(@"..\Test.txt", requiredEncoding);
        StreamWriter writer = new StreamWriter(@"..\Test_Result.txt");

        using (reader)
        {
            using (writer)
            {
                string readedTextRow = reader.ReadLine();

                while (readedTextRow != null)
                {
                    readedTextRow = readedTextRow.Replace(" test", " ");

                    if (readedTextRow[0] == 't' && readedTextRow[1] == 'e' && readedTextRow[2] == 's' && readedTextRow[3] == 't')
                    {
                        int index = readedTextRow.IndexOf('t');
                        readedTextRow.ToString().Remove(index, 4);
                    }

                    writer.WriteLine(readedTextRow);
                    readedTextRow = reader.ReadLine();
                }
            }
        }
    }
}