////Write a program that extracts from a given text all sentences containing given word.
////    Example: The word is "in". The text is:
////        We are living in a yellow submarine. We don't have 
////        anything else. Inside the submarine is very tight. 
////        So we are drinking all the day. We will move out 
////        of it in 5 days.
////    The expected result is:
////        We are living in a yellow submarine.
////        We will move out of it in 5 days.
////    Consider that the sentences are separated by "." and the words – by non-letter symbols.

using System;
using System.IO;
using System.Linq;
using System.Text;

class ExtractSentencesContainingGivenWord
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"..\text.txt");
        StringBuilder extract = new StringBuilder();

        using (reader)
        {
            string readedText = reader.ReadToEnd();
            char[] readedChar = readedText.ToCharArray();

            int startAppendingIndex = 0;
            int endAppendingIndex = readedText.IndexOf('.', startAppendingIndex);

            bool check = false;

            for (int i = 1; i < readedText.Length - 2; i++)
            {
                if ((readedChar[i - 1] == ' ') && (readedChar[i] == 'i') && (readedChar[i + 1] == 'n') && (readedChar[i + 2] == ' '))
                {
                    check = true;
                }
                if (check == true && readedChar[i] == '.')
                {
                    for (int j = startAppendingIndex; j <= endAppendingIndex; j++)
                    {
                        extract.Append(readedChar[j]);
                    }
                }
                if (readedChar[i] == '.')
                {
                    startAppendingIndex = i + 1;
                    check = false;
                }
                endAppendingIndex = readedText.IndexOf('.', startAppendingIndex);
            }
            Console.WriteLine(extract);
        }
    }
}