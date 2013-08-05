using System;

class WeAllLoveBits
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[] array = new int[n];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        int[] invertedArray = new int[n];

        for (int i = 0; i < n; i++)
        {
            int[] oArray = new int[n];
            oArray[i] = array[i];
            for (int j = 0; j < 32; j++)
            {
                if (oArray[i] > Math.Pow(2, j))
                {
                    if ((oArray[i] & (1 << j)) == 0)
                    {
                        invertedArray[i] = oArray[i] | (1 << j);
                        oArray[i] = oArray[i] | (1 << j);
                    }
                    else
                    {
                        invertedArray[i] = oArray[i] & (~(1 << j));
                        oArray[i] = oArray[i] & (~(1 << j));
                    }
                }
                else
                {
                    break;
                }
            }
        }

        int[] reversedArray = new int[n];

        for (int i = 0; i < n; i++)
        {
            int[] oArray = new int[n];
            oArray[i] = 0;

            int bitCounter = 0;
            for (int j = 0; j < 32; j++)
            {
                if (array[i] > Math.Pow(2, j))
                {
                    bitCounter++;
                }
                else
                {
                    break;
                }
            }
            for (int j = 0; j < bitCounter; j++)
            {
                if ((array[i] & (1 << j)) == 0)
                {
                    reversedArray[i] = oArray[i] & (~(1 << (bitCounter - 1 - j)));
                    oArray[i] = oArray[i] & (~(1 << (bitCounter - 1 - j)));
                }
                else
                {
                    reversedArray[i] = oArray[i] | 1 << (bitCounter - 1 - j);
                    oArray[i] = oArray[i] | 1 << (bitCounter - 1 - j);
                }
            }
        }

        int[] newArray = new int[n];

        for (int i = 0; i < array.Length; i++)
        {
            newArray[i] = (array[i] ^ invertedArray[i]) & reversedArray[i];
        }

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(newArray[i]);
        }
    }
}