using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        string[,] dataArray = new string[n, 6];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                switch (j)
                {
                    case 0: Console.Write("Enter \"First name\" of person No: {0}: ", (i + 1)); break;
                    case 1: Console.Write("Enter \"Last name\" of person No: {0}: ", (i + 1)); break;
                    case 2: Console.Write("Enter \"Year of birth\" of person No: {0}: ", (i + 1)); break;
                    case 3: Console.Write("Enter \"Eye color\" of person No: {0}: ", (i + 1)); break;
                    case 4: Console.Write("Enter \"Hair color\" of person No: {0}: ", (i + 1)); break;
                    case 5: Console.Write("Enter \"Height\" of person No: {0}: ", (i + 1)); break;
                }
                dataArray[i, j] = Console.ReadLine();
            }
            Console.WriteLine();
        }
        //===========================================================================================================


        char p = dataArray[1, 1][0];
        Console.WriteLine(p);


        //Задачата все още не е решена, ще трябва някой ден и това да стане!!!!!!!!!!!!!!!!!!!!

        //===========================================================================================================
        for (int i = 0; i < n; i++)                 //printing the result
        {
            for (int j = 0; j < 6; j++)
            {
                Console.WriteLine(dataArray[n, 6]);
            }
            Console.WriteLine();
        }
    }
}