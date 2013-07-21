using System;
using System.Text;

class PrintIsoscelesTriangle
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        char c = '\u00A9';
        Console.WriteLine("    {0}", c);
        Console.WriteLine("  {0} {1} {2}", c, c, c);
        Console.WriteLine("{0} {1} {2} {3} {4}", c, c, c, c, c);
    }
}