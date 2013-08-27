//// Write a program that reads a text file containing a square matrix of numbers and finds 
//// in the matrix an area of size 2 x 2 with a maximal sum of its elements. The first line in 
//// the input file contains the size of matrix N. Each of the next N lines contain N numbers 
//// separated by space. The output should be a single number in a separate text file. 
//// Example:
//// 4
//// 2 3 3 4
//// 0 2 3 4		-->  	17
//// 3 7 1 2
//// 4 3 3 2

using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FindingMatrixWithMaximalSumOfElements
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"..\MatrixFile.txt");

        string readed = reader.ReadLine();

        string[] stringMatrix = new string[int.Parse(readed)];

        readed = reader.ReadLine();
        for (int i = 0; i < stringMatrix.Length; i++)
        {
            stringMatrix[i] = readed;
            stringMatrix[i] = stringMatrix[i].Replace(" ", string.Empty);
            readed = reader.ReadLine();
        }

        int[,] matrix = new int[stringMatrix.Length, stringMatrix.Length];
        int fromCharToIntConversion = 48;

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = stringMatrix[row][col] - fromCharToIntConversion;
            }
        }

        int currentSum = 0;
        int maxSum = 0;

        for (int row = 0; row < matrix.GetLength(0) - 1; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                currentSum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];
                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                }
            }
        }
        string maxSumAsString = maxSum.ToString();

        StreamWriter writer = new StreamWriter(@"..\OutputFile.txt");
        using (writer)
        {
            writer.WriteLine(maxSumAsString);
        }
    }
}