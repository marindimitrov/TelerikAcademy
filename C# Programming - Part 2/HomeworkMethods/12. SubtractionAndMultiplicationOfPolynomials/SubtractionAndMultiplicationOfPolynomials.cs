//Extend the program to support also subtraction and multiplication of polynomials.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SubtractionAndMultiplicationOfPolynomials
{
    static void Main()
    {
        int[] polynomOne = new int[] { 4, 3, 1 };
        int[] polynomTwo = new int[] { -2, 3, 7 };
        int[] result = new int[3];

        Subtraction(polynomOne, polynomTwo, result);
        Multiplication(polynomOne, polynomTwo, result);
    }

    public static void Subtraction(int[] polynomOne, int[] polynomTwo, int[] result)
    {
        for (int i = 0; i < 3; i++)
        {
            result[i] = polynomOne[i] - polynomTwo[i];
        }

        Console.WriteLine("The result is: ");
        Console.WriteLine("{2}x^2 + {1}x + {0}", result[0], result[1], result[2]);
    }

    public static void Multiplication(int[] polynomOne, int[] polynomTwo, int[] result)
    {
        for (int i = 0; i < 3; i++)
        {
            result[i] = polynomOne[i] * polynomTwo[i];
        }

        Console.WriteLine("The result is: ");
        Console.WriteLine("{2}x^4 + {1}x^2 + {0}", result[0], result[1], result[2]);
    }
}