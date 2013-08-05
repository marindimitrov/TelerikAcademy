using System;

class BinaryDigitsCount
{
    static void Main()
    {
        int b = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        uint[] array = new uint[n];

        for (int i = 0; i < n; i++)
        {
            array[i] = uint.Parse(Console.ReadLine());
        }

        int bitCounter = 0;

        if (b == 1)
        {
            foreach (var number in array)
            {
                for (int j = 0; j < 32; j++)
                {
                    if ((number & (1 << j)) != 0)
                    {
                        bitCounter++;
                    }
                }
                Console.WriteLine(bitCounter);
                bitCounter = 0;
            }
        }

        else if (b == 0)
        {
            for (int i = 0; i < n; i++ )
            {
                for (int j = 0; j < 32; j++)
                {
                    if ((array[i] & (1 << j)) == 0)
                    {
                        bitCounter++;
                    }
                }

                int count = 0;
                uint number = array[i];

                while ((number / 2) > 0)
                {
                    number = number / 2;
                    count++;
                }

                bitCounter = bitCounter - (31 - count);
                Console.WriteLine(bitCounter);
                bitCounter = 0;
            }
        }
    }
}