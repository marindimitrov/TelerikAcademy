//Write a program that reads a text file and inserts line numbers in front of each of its lines. 
//The result should be written to another text file.

using System;
using System.IO;

class InsertLineNumbersInTextFile
{
    static void Main()
    {
        string initialFile = @"..\InitialFile.txt";
        string lineNumberedText = @"..\LineNumberedText.txt";

        try
        {
            StreamReader reader = new StreamReader(initialFile);
            using (reader)
            {
                StreamWriter writer = new StreamWriter(lineNumberedText);
                using (writer)
                {
                    string readed = reader.ReadLine();
                    int number = 1;

                    while (readed != null)
                    {
                        writer.Write(number + ". ");
                        writer.WriteLine(readed);
                        number++;
                        readed = reader.ReadLine();
                    }
                }
            }
        }
        catch(FileNotFoundException)
        {
            Console.Error.WriteLine("Cannot find file {0}", initialFile);
        }
        catch(IOException)
        {
            Console.WriteLine("Cannot read file {0}", lineNumberedText);
        }
        catch(Exception)
        {
            Console.WriteLine("There is problem, contact administrator.");
        }
    }
}