////Write a program that encodes and decodes a string using given encryption key (cipher). 
////The key consists of a sequence of characters. The encoding/decoding is done by performing 
////XOR (exclusive or) operation over the first letter of the string with the first of the key, 
////the second – with the second, etc. When the last key character is reached, the next is the first.

using System;

class EncodeAndDecodeStringWithCipher
{
    static void Main()
    {
        string inputString = "This string will be encoded.";
        Console.Write("This is the input string--> {0}\n", inputString);
        string cipher = "mycipher";

        string encodedString = Encode(inputString, cipher);
        Console.Write("This is the encoded string--> ");
        PrintResult(encodedString);

        string decodedString = Decode(encodedString, cipher);
        Console.Write("This is the decoded string--> ");
        PrintResult(decodedString);
    }
    public static string Encode(string stringToBeEncoded, string cipher)
    {
        char[] encodedCharArr = new char[stringToBeEncoded.Length];
        int[] encodedIntArr = new int[stringToBeEncoded.Length];

        for (int i = 0; i < stringToBeEncoded.Length; i++)
        {
            encodedIntArr[i] = (int)stringToBeEncoded[i] ^ (int)cipher[i % cipher.Length];
        }

        for (int i = 0; i < stringToBeEncoded.Length; i++)
        {
            encodedCharArr[i] = (char)encodedIntArr[i];
        }
        string encodedString = new string(encodedCharArr);
        return encodedString;
    }
    public static string Decode(string encodedString, string cipher)
    {
        char[] encodedStringAsCharArray = encodedString.ToCharArray();
        char[] decodedCharArr = new char[encodedStringAsCharArray.Length];
        int[] decodedIntArr = new int[decodedCharArr.Length];

        for (int i = 0; i < encodedStringAsCharArray.Length; i++)
        {
            decodedIntArr[i] = (int)encodedStringAsCharArray[i] ^ (int)cipher[i % cipher.Length];
        }

        for (int i = 0; i < encodedStringAsCharArray.Length; i++)
        {
            decodedCharArr[i] = (char)decodedIntArr[i];
        }
        string decodedString = new string(decodedCharArr);
        return decodedString;
    }
    public static void PrintResult(string stringToPrint)
    {
        foreach (var item in stringToPrint)
        {
            Console.Write(item);
        }
        Console.WriteLine();
    }
}