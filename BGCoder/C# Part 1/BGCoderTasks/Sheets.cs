using System;

class Sheets
{
    static void Main()
    {
        checked
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 11; i >= 0; i--)
            {
                int currentSheet = (int)Math.Pow(2, i);
                if (currentSheet <= n && n >= 0)
                {
                    n -= currentSheet;
                }
                else
                {
                    switch (i)
                    {
                        case 10: Console.WriteLine("A0"); break;
                        case 9: Console.WriteLine("A1"); break;
                        case 8: Console.WriteLine("A2"); break;
                        case 7: Console.WriteLine("A3"); break;
                        case 6: Console.WriteLine("A4"); break;
                        case 5: Console.WriteLine("A5"); break;
                        case 4: Console.WriteLine("A6"); break;
                        case 3: Console.WriteLine("A7"); break;
                        case 2: Console.WriteLine("A8"); break;
                        case 1: Console.WriteLine("A9"); break;
                        case 0: Console.WriteLine("A10"); break;
                    }
                }
            }
        }
    }
}