using System;

class ExcelColumns
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[] input = new string[n];
        int index = 0;

        for (int i = 0; i < n; i++)
        {
            input[i] = Console.ReadLine();
            string symbol = input[i];
            int number = 0;

            switch (symbol)
            {
                case "A": number = 1; break;
                case "B": number = 2; break;
                case "C": number = 3; break;
                case "D": number = 4; break;
                case "E": number = 5; break;
                case "F": number = 6; break;
                case "G": number = 7; break;
                case "H": number = 8; break;
                case "I": number = 9; break;
                case "J": number = 10; break;
                case "K": number = 11; break;
                case "L": number = 12; break;
                case "M": number = 13; break;
                case "N": number = 14; break;
                case "O": number = 15; break;
                case "P": number = 16; break;
                case "Q": number = 17; break;
                case "R": number = 18; break;
                case "S": number = 19; break;
                case "T": number = 20; break;
                case "U": number = 21; break;
                case "V": number = 22; break;
                case "W": number = 23; break;
                case "X": number = 24; break;
                case "Y": number = 25; break;
                case "Z": number = 26; break;
            }

            int result = 0;

            if (i < n - 1)
            {
                result = number * (int)Math.Pow(26, (n - i - 1));
            }
            else
            {
                result = number;
            }
            index += result;
        }
        Console.WriteLine(index);
    }
}