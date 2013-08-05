//We are given a matrix of strings of size N x M. 
//Sequences in the matrix we define as sets of several 
//neighbor elements located on the same line, column 
//or diagonal. Write a program that finds the longest 
//sequence of equal strings in the matrix.

using System;

class MatrixLongestSequenceOfEqualStrings
{
    static int longestSequenceStartRowIndex = 0;
    static int longestSequenceStartColIndex = 0;
    static int counter = 1;
    static int maxCounter = 0;
    static string direction = "";

    static void Main()
    {
        string[,] matrix = new string[,] 
        {
            {"ha","fifi","ho","hi"},
            {"fo","ha","hi","xx"},
            {"xxx","ho","ha","xx"}
        };

        for (int i = 0; i < matrix.GetLength(0) - 1; i++)
        {
            for (int j = 0; j < matrix.GetLength(1) - 1; j++)
            {
                CheckByDirections(matrix, i, j);
            }
        }

        PrintLongestSequence(matrix);
    }

    public static void CheckByDirections(string[,] matrix, int i, int j)
    {
        //this is horizontals check: 
        for (int k = j; k < matrix.GetLength(1) - 1; k++)
        {
            if (matrix[i, k] == matrix[i, k + 1])
            {
                counter++;

                if (counter > maxCounter)
                {
                    maxCounter = counter;
                    longestSequenceStartRowIndex = i;
                    longestSequenceStartColIndex = j;
                    direction = "horizontal";
                }
            }
            else
            {
                break;
            }
        }
        counter = 1;

        // this is verticals checks:
        for (int k = i; k < matrix.GetLength(0) - 1; k++)
        {
            if (matrix[k, j] == matrix[k + 1, j])
            {
                counter++;

                if (counter > maxCounter)
                {
                    maxCounter = counter;
                    longestSequenceStartRowIndex = i;
                    longestSequenceStartColIndex = j;
                    direction = "vertical";
                }
            }
            else
            {
                break;
            }
        }
        counter = 1;

        //this is diagonals checks:
        int diagonalLength = ((matrix.GetLength(0) > matrix.GetLength(1))
                             ? matrix.GetLength(1) : matrix.GetLength(0));
        for (int k = i; k < diagonalLength - 1; k++, j++)
        {
            if (matrix[k, j] == matrix[k + 1, j + 1])
            {
                counter++;

                if (counter > maxCounter)
                {
                    maxCounter = counter;
                    longestSequenceStartRowIndex = i;
                    longestSequenceStartColIndex = j;
                    direction = "diagonal";
                }
            }
            else
            {
                break;
            }
        }
    }

    public static void PrintLongestSequence(string[,] matrix)
    {
        if (direction == "horizontal")
        {
            for (int col = longestSequenceStartColIndex; col <= longestSequenceStartColIndex + counter; col++)
            {
                Console.Write(matrix[longestSequenceStartRowIndex, col] + " ");
            }
        }
        else if (direction == "vertical")
        {
            for (int row = longestSequenceStartRowIndex; row <= longestSequenceStartRowIndex + counter; row++)
            {
                Console.Write(matrix[row, longestSequenceStartColIndex] + " ");
            }
        }
        else if (direction == "diagonal")
        {
            for (int i = longestSequenceStartRowIndex, j = longestSequenceStartColIndex; i <= longestSequenceStartRowIndex + counter; i++, j++)
            {
                Console.Write(matrix[i,j] + " ");
            }
        }
    }
}