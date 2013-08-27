////Write a program that extracts from given HTML file its title 
////(if available), and its body text without the HTML tags. 
////    Example:
////      <html>
////        <head><title>News</title></head>
////        <body><p><a href="http://academy.telerik.com">Telerik
////          Academy</a>aims to provide free real-world practical
////          training for young people who want to turn into
////          skillful .NET software engineers.</p></body>
////      </html>

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ExtractTitleAndBodyFromHtmlFile
{
    static void Main()
    {
        string readedDoc = ReadFile(@"..\doc.html");

        StringBuilder result = GetResult(readedDoc);

        Console.WriteLine(result);
    }
    public static string ReadFile(string readFilePath)
    {
        StreamReader reader = new StreamReader(readFilePath);
        string readedDoc = null;
        using (reader)
        {
            readedDoc = reader.ReadToEnd();
        }
        return readedDoc;
    }
    public static StringBuilder GetResult(string readedDoc)
    {
        StringBuilder result = new StringBuilder();
        string approve = "yes";
        foreach (var letter in readedDoc)
        {
            if (letter == '<')
            {
                approve = "no";
            }
            if (letter == '>')
            {
                approve = "yes";
            }
            if (approve == "yes")
            {
                result.Append(letter);
            }
        }
        result.Replace('>', ' ');
        return result;
    }
}