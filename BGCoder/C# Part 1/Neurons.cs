using System;

class Neurons
{
    static void Main()
    {
        int border = 0;

        int[] inputArr = new int[32];
        for (int i = 0; i < 32; i++)
        {
            inputArr[i] = 0;
        }
        for (int i = 0; i < 32; i++)
        {
            inputArr[i] = int.Parse(Console.ReadLine());
            if (inputArr[i] == -1)
            {
                border = i;
                break;
            }
        }
        int[,] array = new int[border, 32];

        for (int i = 0; i < border; i++)
        {
            for (int j = 0; j < 32; j++)
            {
                array[i, j] = (inputArr[i] & (1 << 31 - j)) / (1 << 31 - j);
            }
        }
        string[,] stringArr = new string[32, 32];
        for (int i = 0; i < border; i++)
        {
            for (int j = 0; j < 32; j++)
            {
                if (array[i, j] == 0)
                {
                    stringArr[i, j] = ".";
                }
                else
                {
                    stringArr[i, j] = "1";
                }
            }
        }
        for (int i = 0; i < border; i++)
        {
            if (inputArr[i] == -1)
            {
                for (int j = 0; j < 32; j++)
                {
                    stringArr[i, j] = ".";
                }
            }
        }

        for (int i = 0; i < border; i++)
        {
            for (int j = 0; j < 32; j++)
            {
                if (stringArr[i, j] == "1")
                {
                    for (int m = 0; m < j; m++)
                    {
                        stringArr[i, m] = "1";
                    }
                    break;
                }
            }
        }
        for (int i = 0; i < border; i++)
        {
            for (int j = 31; j >= 0; j--)
            {
                if (stringArr[i, j] == "1")
                {
                    for (int m = 31; m > j; m--)
                    {
                        stringArr[i, m] = "1";
                    }
                    break;
                }
            }
        }
        for (int i = 0; i < border; i++)
        {
            if (inputArr[i] == -1)
            {
                for (int k = i - 1; k < 32; k++)
                {
                    for (int l = 0; l < 32; l++)
                    {
                        stringArr[k, l] = "1";
                    }
                }
            }
        }

        for (int i = 0; i < border; i++)
        {
            for (int j = 0; j < 32; j++)
            {
                if (stringArr[i, j] == "1")
                {
                    stringArr[i, j] = ".";
                }
                else
                {
                    stringArr[i, j] = "1";
                }
            }
        }

        for (int j = 0; j < 32; j++)
        {
            stringArr[border - 1, j] = ".";
        }

        int[] result = new int[border];
        for (int i = 0; i < border; i++)
        {
            result[i] = 0;
        }


        for (int i = 0; i < border; i++)
        {
            for (int j = 0; j < 32; j++)
            {
                if (stringArr[i, j] == "1")
                {
                    result[i] += 1 << (32 - j);
                }
            }
        }

        for (int i = 0; i < border; i++)
        {
            result[i] /= 2;
        }

        for (int i = 0; i < border; i++)
        {
            Console.WriteLine(result[i]);
        }

        //for (int i = 0; i < border; i++)
        //{
        //    for (int j = 0; j < 32; j++)
        //    {
        //        Console.Write(stringArr[i, j]);
        //    }
        //    Console.WriteLine();
        //}
    }
}