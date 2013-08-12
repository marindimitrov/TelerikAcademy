//Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), 
//reads its contents and prints it on the console. Find in MSDN how to use System.IO.File.ReadAllText(…). 
//Be sure to catch all possible exceptions and print user-friendly error messages.

using System;
using System.IO;

class SystemIOFileReadAllText
{
    public static void ReadFromFileAndPrint(string pathToRead)
    {
        string readedTextFromMyFile = File.ReadAllText(pathToRead);
        Console.WriteLine(readedTextFromMyFile);
    }
    public static void Main()
    {
        try
        {
            string pathToRead = @"c:\windows\win.ini";
            ReadFromFileAndPrint(pathToRead);
        }
        catch (ArgumentNullException ane)
        {
            Console.WriteLine("The readed path is null.");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("The readed path is a zero-length string, contains only white space, or contains one or more invalid characters as defined by InvalidPathChars.");
        }
        catch (PathTooLongException)
        {
            Console.WriteLine("The specified path, file name, or both exceed the system-defined maximum length. On Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters.");
        }
        catch (System.Security.SecurityException)
        {
            Console.WriteLine("The caller does not have the required permission.");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("Path specified a file that is read-only;\nor this operation is not supported on the current platform;\nor path specified a directory;\nor the caller does not have the required permission.");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("The specified path is invalid. Please check if the path exist.");
        }
        catch (NotSupportedException)
        {
            Console.WriteLine("The path is in an invalid format.");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("The file specified in path was not found.");
        }
        catch (IOException)
        {
            Console.WriteLine("An I/O error occurred while opening the file.");
        }

    }
}