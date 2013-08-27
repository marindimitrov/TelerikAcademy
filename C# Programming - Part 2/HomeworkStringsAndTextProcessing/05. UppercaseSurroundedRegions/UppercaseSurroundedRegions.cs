////You are given a text. Write a program that changes the text in all 
////regions surrounded by the tags <upcase> and </upcase> to uppercase. 
////The tags cannot be nested. Example:
////    We are living in a <upcase>yellow submarine</upcase>. 
////    We don't have <upcase>anything</upcase> else.
////The expected result:
////    We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.

using System;
using System.IO;
using System.Linq;
using System.Text;

class UppercaseSurroundedRegions
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"..\text.txt");
        StreamWriter writer = new StreamWriter(@"..\uppercased text.txt");
        StringBuilder editedText = new StringBuilder();

        using (reader)
        {
            using (writer)
            {
                string readedText = reader.ReadToEnd();
                char[] readedTextAsCharArray = readedText.ToCharArray();

                for (int i = 0; i < readedTextAsCharArray.Length; i++)
                {
                    while (readedTextAsCharArray[i] != '<' && i != (readedTextAsCharArray.Length - 1))
                    {
                        editedText.Append(readedTextAsCharArray[i]);
                        i++;
                    }
                    if (readedTextAsCharArray[i] == '<')
                    {
                        while (readedTextAsCharArray[i] != '>')
                        {
                            i++;
                        }
                    }
                    if (readedTextAsCharArray[i] == '>')
                    {
                        i++;
                        while (readedTextAsCharArray[i] != '<')
                        {
                            editedText.Append(readedTextAsCharArray[i].ToString().ToUpper());
                            i++;
                        } 
                    }
                    if (readedTextAsCharArray[i] == '<')
                    {
                        while (readedTextAsCharArray[i] != '>')
                        {
                            i++;
                        }
                    }
                }
                writer.WriteLine(editedText);
            }
        }
    }
}