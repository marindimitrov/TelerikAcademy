////Write a program that extracts from given XML file all the text without the tags. 
////Example:
////<?xml version="1.0"><student><name>Pesho</name>
////<age>21</age><interests count="3"><interest> 
////Games</instrest><interest>C#</instrest><interest> 
////Java</instrest></interests></student>

using System;
using System.IO;
using System.Linq;
using System.Text;

class ExtractTextWithoutTags
{
    static void Main()
    {
        Encoding requiredEncoding = Encoding.GetEncoding("Windows-1251");

        StringBuilder textWithoutTags = new StringBuilder();

        StreamReader reader = new StreamReader(@"..\My XML File.xml", requiredEncoding);
        StreamWriter writer = new StreamWriter(@"..\Text without tags.txt");

        char readedChar = (char)reader.Read();

        using (writer)
        {
            using (reader)
            {
                char outOfRangeSymbol = (char)255;
                while (readedChar < outOfRangeSymbol)
                {
                    if (readedChar == '<')
                    {
                        do
                        {
                            readedChar = (char)reader.Read();
                        } while (readedChar != '>');
                        readedChar = (char)reader.Read();
                    }
                    else
                    {
                        textWithoutTags.Append(readedChar);
                        readedChar = (char)reader.Read();
                    }
                }  
            }
            writer.WriteLine(textWithoutTags);
        }
    }
}