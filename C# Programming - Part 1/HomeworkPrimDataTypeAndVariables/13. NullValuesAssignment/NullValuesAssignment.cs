using System;

class NullValuesAssignment
{
    static void Main()
    {
        int? i = null;
        double? d = null;
        Console.WriteLine("null->" + i + "<-null");
        Console.WriteLine("null->" + d + "<-null");
        Console.WriteLine(i + 3);
        Console.WriteLine(d + 3.4);
    }
}
