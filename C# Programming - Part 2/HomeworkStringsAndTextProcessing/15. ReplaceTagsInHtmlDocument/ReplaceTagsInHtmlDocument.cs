////Write a program that replaces in a HTML document given as string all 
////the tags <a href="…">…</a> with corresponding tags [URL=…]…[/URL]. 
////Sample HTML fragment:
////    <p>Please visit <a href="http://academy.telerik.
////    com">our site</a> to choose a training course. 
////    Also visit <a href="www.devbg.org">our forum</a> 
////    to discuss the courses.</p>
////
////        <p>Please visit [URL=http://academy.telerik.
////        com]our site[/URL] to choose a training course. 
////        Also visit [URL=www.devbg.org]our forum[/URL] 
////        to discuss the courses.</p>

using System;
using System.IO;
using System.Linq;

class ReplaceTagsInHtmlDocument
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"..\test.html");
        string readedText = reader.ReadToEnd();
        using (reader)
        {
            readedText = readedText.Replace("<a href=", "[URL=");
            readedText = readedText.Replace("\">", "]");
            readedText = readedText.Replace("</a>", "[/URL]");
        }
        StreamWriter writer = new StreamWriter(@"..\result.html");
        using (writer)
        {
            writer.WriteLine(readedText);
        }
        Console.WriteLine(readedText);
    }
}