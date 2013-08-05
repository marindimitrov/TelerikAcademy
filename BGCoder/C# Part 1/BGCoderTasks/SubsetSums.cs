using System;

class SubsetSums
{
    static void Main()
    {
        int countNum = int.Parse(Console.ReadLine());
        long result = 0;
        int counter = 0;

        long[] array = new long[countNum];

        for (int i = 0; i < countNum; i++)
        {
            array[i] = long.Parse(Console.ReadLine());
        }

        for (int i = 0; i < countNum; i++)
        {
            if (array[i] == countNum)
            {
                counter++;
            }
        }

        for (int i = 0; i < countNum; i++)
        {
            for (int j = 0; j < countNum; j++)
            {
                if (i != j)
                {
                    result = array[i] + array[j];
                    if (result == countNum)
                    {
                        counter++;
                    }
                }
            }
        }
        for (int i = 0; i < countNum; i++)
        {
            for (int j = 0; j < countNum; j++)
            {
                for (int k = 0; k < countNum; k++)
                {
                    if (i != j && i != k && j != k)
                    {
                        result = array[i] + array[j] + array[k];
                        if (result == countNum)
                        {
                            counter++;
                        }
                    }
                }
            }
        }
        Console.WriteLine(counter);
    }
}