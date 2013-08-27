////Write a program that parses an URL address given in the format:
////    [protocol]://[server]/[resource]
////and extracts from it the [protocol], [server] and [resource] elements. 
////For example from the URL http://www.devbg.org/forum/index.php the following 
////information should be extracted:
////    [protocol] = "http"
////    [server] = "www.devbg.org"
////    [resource] = "/forum/index.php"

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class ExtractElementsFromURLaddress
{
    static void Main()
    {
        LongImplementedSolution();
        //ShortSolution();
    }

    public static void ShortSolution()
    {
        List<string> websitesList = new List<string>() { "http://www.devbg.org/forum/index.php" };

        var uris = websitesList.Select(u => new Uri(u));

        foreach (var uri in uris)
        {
            var schema = uri.Scheme;
            Console.WriteLine(schema);

            var host = uri.Host;
            Console.WriteLine(host);

            var query = uri.Query;
            Console.WriteLine(query);
        }
    }

    public static void LongImplementedSolution()
    {
        string website = "http://www.devbg.org/forum/index.php";

        StringBuilder elements = new StringBuilder();

        int startIndexOfProtocol = 0;
        int endIndexOfProtocol = website.IndexOf(':');
        int startIndexOfServer = website.IndexOf("www");
        int endIndexOfServer = website.IndexOf('/', startIndexOfServer);
        int startIndexOfResource = endIndexOfServer;
        int endIndexOfResource = website.Length;

        for (int i = startIndexOfProtocol; i < endIndexOfProtocol; i++)
        {
            elements.Append(website[i]);
        }
        Console.WriteLine("[protokol] = {0}", elements);
        elements.Clear();

        for (int i = startIndexOfServer; i < endIndexOfServer; i++)
        {
            elements.Append(website[i]);
        }
        Console.WriteLine("[server] = {0}", elements);
        elements.Clear();

        for (int i = startIndexOfResource; i < endIndexOfResource; i++)
        {
            elements.Append(website[i]);
        }
        Console.WriteLine("[resource] = {0}", elements);
        elements.Clear();
    }
}