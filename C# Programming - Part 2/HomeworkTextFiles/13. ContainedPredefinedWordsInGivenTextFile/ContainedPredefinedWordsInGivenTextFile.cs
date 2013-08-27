////Write a program that reads a list of words from a file words.txt and finds how many times 
////each of the words is contained in another file test.txt. The result should be written in 
////the file result.txt and the words should be sorted by the number of their occurrences in 
////descending order. Handle all possible exceptions in your methods.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class ContainedPredefinedWordsInGivenTextFile
{
    static void Main()
    {
        List<string> words = ReadingWordsFromFile(@"..\words.txt");
        string[] testFileAsArray = ReadTestFile(@"..\test.txt");
        List<string> results = GetResultsInList(words, testFileAsArray);
        SaveResultsInFile(@"..\result.txt", results);
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
    public static string[] ReadTestFile(string readFromFile)
    {
        try
        {
            StreamReader reader = new StreamReader(readFromFile);
            using (reader)
            {
                string testFileAsString = reader.ReadToEnd();
                string[] testFileAsArray = testFileAsString.Split(' ');
                return testFileAsArray;
            }
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
    public static List<string> GetResultsInList(List<string> words, string[] testFileAsArray)
    {
        try
        {
            List<string> result = new List<string>();

            int counter = 0;

            foreach (var word in words)
            {
                foreach (var item in testFileAsArray)
                {
                    if (word == item)
                    {
                        counter++;
                    }
                }
                result.Add(counter.ToString() + " " + word);
                counter = 0;
            }
            result.Sort();
            return result;
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
    public static void SaveResultsInFile(string writedResultFile, List<string> results)
    {
        try
        {
            StreamWriter writer = new StreamWriter(writedResultFile);
            using (writer)
            {
                foreach (var item in results)
                {
                    writer.WriteLine(item);
                }
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