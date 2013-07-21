//Write a program that exchanges bits 3, 4 and 5 with 
//bits 24, 25 and 26 of given 32-bit unsigned integer.

using System;

class ExchangeBitsOnUnsignedInteger
{
    static void Main()
    {
        Console.Write("Enter number and press \"Enter\" to see the number after bit exchange: ");
        int number = int.Parse(Console.ReadLine());

        int maskThree = 1 << 3;
        int maskFour = 1 << 4;
        int maskFive = 1 << 5;
        int maskTwentyFour = 1 << 24;
        int maskTwentyFive = 1 << 25;
        int maskTwentySix = 1 << 26;

        int bitThree = ((number & maskThree) == Math.Pow(2, 3)) ? 1 : 0;
        int bitFour = ((number & maskFour) == Math.Pow(2, 4)) ? 1 : 0;
        int bitFive = ((number & maskFive) == Math.Pow(2, 5)) ? 1 : 0;
        int bitTwentyFour = ((number & maskTwentyFour) == Math.Pow(2, 24)) ? 1 : 0;
        int bitTwentyFive = ((number & maskTwentyFive) == Math.Pow(2, 25)) ? 1 : 0;
        int bitTwentySix = ((number & maskTwentySix) == Math.Pow(2, 26)) ? 1 : 0;

        int bitThreeChanged = bitTwentyFour;
        int bitFourChanged = bitTwentyFive;
        int bitFiveChanged = bitTwentySix;
        int bitTwentyFourChanged = bitThree;
        int bitTwentyFiveChanged = bitFour;
        int bitTwentySixChanged = bitFive;

        if (bitThreeChanged == 1)
        {
            number = number | maskThree;
        }
        else if (bitThreeChanged == 0)
        {
            number = number & (~maskThree);
        }
        if (bitFourChanged == 1)
        {
            number = number | maskFour;
        }
        else if (bitFourChanged == 0)
        {
            number = number & (~maskFour);
        }
        if (bitFiveChanged == 1)
        {
            number = number | maskFive;
        }
        else if (bitFiveChanged == 0)
        {
            number = number & (~maskFive);
        }
        if (bitTwentyFourChanged == 1)
        {
            number = number | maskTwentyFour;
        }
        else if (bitTwentyFourChanged == 0)
        {
            number = number & (~maskTwentyFour);
        }
        if (bitTwentyFiveChanged == 1)
        {
            number = number | maskTwentyFive;
        }
        else if (bitTwentyFiveChanged == 0)
        {
            number = number & (~maskTwentyFive);
        }
        if (bitTwentySixChanged == 1)
        {
            number = number | maskTwentySix;
        }
        else if (bitTwentySixChanged == 0)
        {
            number = number & (~maskTwentySix);
        }
        Console.WriteLine("The changed new number is: {0}", number);
    }
}