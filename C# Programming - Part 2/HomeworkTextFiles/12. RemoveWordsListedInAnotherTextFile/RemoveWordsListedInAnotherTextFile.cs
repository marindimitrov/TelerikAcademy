////Write a program that removes from a text file all words listed in given another text file. 
////Handle all possible exceptions in your methods.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

class RemoveWordsListedInAnotherTextFile
{
    static void Main()
    {
        List<string> wordList = ReadingWordsFromFile(@"..\Word List.txt");
        StringBuilder textWithoutWords = RemoveWordsFromText(wordList);
        WriteTextWithoutWords(textWithoutWords);
    }
    public static List<string> ReadingWordsFromFile(string wordsFilePath)
    {
        try
        {
            List<string> words = new List<string>();

            StreamReader wordsReader = new StreamReader(wordsFilePath);
            using (wordsReader)
            {
                string readedWords = wordsReader.ReadLine();
                while (readedWords != null)
                {
                    words.Add(readedWords);
                    readedWords = wordsReader.ReadLine();
                }
            }
            return words;
        }
        catch (IOException ioe)
        {
            Console.WriteLine(ioe.Message);
            return null;
        }
        catch (OutOfMemoryException ome)
        {
            Console.WriteLine(ome.Message);
            return null;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            return null;
        }
    }
    public static StringBuilder RemoveWordsFromText(List<string> wordList)
    {
        try
        {
            StringBuilder textWithoutWords = new StringBuilder();
            StreamReader textReader = new StreamReader(@"..\Text.txt");
            using (textReader)
            {
                string readedRowFromText = textReader.ReadLine();

                while (readedRowFromText != null)
                {
                    foreach (string item in wordList)
                    {
                        readedRowFromText = Regex.Replace(readedRowFromText, item, string.Empty);
                    }
                    textWithoutWords.AppendLine(readedRowFromText);
                    readedRowFromText = textReader.ReadLine();
                }
            }
            return textWithoutWords;
        }
        catch (IOException ioe)
        {
            Console.WriteLine(ioe.Message);
            return null;
        }
        catch (OutOfMemoryException ome)
        {
            Console.WriteLine(ome.Message);
            return null;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            return null;
        }
    }
    public static void WriteTextWithoutWords(StringBuilder textWithoutWords)
    {
        try
        {
            StreamWriter writer = new StreamWriter(@"..\Text.txt");
            using (writer)
            {
                writer.Write(textWithoutWords);
            }
        }
        catch (IOException ioe)
        {
            Console.WriteLine(ioe.Message);
        }
        catch (OutOfMemoryException ome)
        {
            Console.WriteLine(ome.Message);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}