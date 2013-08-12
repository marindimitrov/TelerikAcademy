//Write a program that downloads a file from Internet (e.g. http://www.devbg.org/img/Logo-BASD.jpg) 
//and stores it the current directory. Find in Google how to download files in C#. Be sure to catch 
//all exceptions and to free any used resources in the finally block.

using System;
using System.Net;

class DownloadFileAndCatchExceptions
{
    static void Main()
    {
        using (WebClient webDownloader = new WebClient())
        {
            try
            {
                webDownloader.DownloadFile("http://www.devbg.org/img/Logo-BASD.jpg", @"c:\downloadedPictureFile.jpg");
            }
            catch (ArgumentNullException ane)
            {
                Console.WriteLine(ane.Message);
            }
            catch (WebException we)
            {
                Console.WriteLine(we.Message);
            }
            catch (NotSupportedException nse)
            {
                Console.WriteLine(nse.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                webDownloader.Dispose();
            }
        }
    }
}