////Write a program that concatenates two text files into another text file.

using System;
using System.IO;
using System.Text;

class ConcatenatesTwoTextFiles
{
    static void Main()
    {
        StreamReader firstTextReader = new StreamReader(@"../FirstText.txt");
        StreamReader secondTextReader = new StreamReader(@"../SecondText.txt");

        StringBuilder myTextBlock = new StringBuilder();

        using (firstTextReader)
        {
            using (secondTextReader)
            {
                string firstReadedText = firstTextReader.ReadToEnd();
                myTextBlock.Append(firstReadedText);

                string secondReadedText = secondTextReader.ReadToEnd();
                myTextBlock.Append(secondReadedText);
            }
        }

        StreamWriter textWriter = new StreamWriter(@"../ConcatenatedFile.txt");

        using (textWriter)
        {
            textWriter.WriteLine(myTextBlock);
        }
    }
}