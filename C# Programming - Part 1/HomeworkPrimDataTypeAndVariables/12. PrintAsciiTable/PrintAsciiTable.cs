using System;
using System.Text;

class PrintAsciiTable
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        int decNumber = 0;
        for (char i = (char)0; i <= 255; i++)
        {
            Console.WriteLine("ASCII code with sequence decimal number {0} is -> {1}", decNumber++, i);
        }
    }
}