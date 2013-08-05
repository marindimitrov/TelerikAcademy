//Write a method that adds two polynomials. Represent them 
//as arrays of their coefficients as in the example below:
//        x2 + 5 = 1x2 + 0x + 5   {5, 0, 1}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class AddsTwoPolynomials
{
    static void Main()
    {
        int[] polynomOne = new int[] { 4, 3, 1 };
        int[] polynomTwo = new int[] { -2, 3, 7 };
        int[] result = new int[3];

        AddPolynoms(polynomOne, polynomTwo, result);
    }

    public static void AddPolynoms(int[] polynomOne, int[] polynomTwo, int[] result)
    {
        for (int i = 0; i < 3; i++)
        {
            result[i] = polynomOne[i] + polynomTwo[i];
        }

        Console.WriteLine("The result is: ");
        Console.WriteLine("{2}x^2 + {1}x + {0}", result[0], result[1], result[2]);
    }
}