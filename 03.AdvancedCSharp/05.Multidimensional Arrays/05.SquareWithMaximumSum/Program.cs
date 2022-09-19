using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.SquareWithMaximumSum
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = input[0];
            int cols = input[1];
            int[,] numMatrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] inputMatric = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int col = 0; col < cols; col++)
                {
                    numMatrix[row, col] = inputMatric[col];
                }
            }

            int innerSquareMatrixRows = 2;
            int innerSquareMatrixCols = 2;
            int maxSum = int.MinValue;
            int maxInnerRow = -1;
            int maxInnerCol = -1;
            for (int row = 0; row < rows - innerSquareMatrixRows + 1; row++)
            {
                for (int col = 0; col < cols - innerSquareMatrixCols + 1; col++)
                {
                    int innerSum = numMatrix[row, col]
                        + numMatrix[row + 1, col]
                        + numMatrix[row, col + 1]
                        + numMatrix[row + 1, col + 1] ;

                    if (innerSum>maxSum)
                    {
                        maxSum = innerSum;
                        maxInnerRow = row;
                        maxInnerCol = col;
                    }
                    {
                    /*for (int innerRow = 0; innerRow < innerSquareMatrixRows; innerRow++)
                    {

                        for (int innerCol = 0; innerCol < innerSquareMatrixCols; innerCol++)
                        {
                            innerSum += numMatrix[row + innerRow, col + innerCol];
                            if (innerSum > maxSum)
                            {
                                maxSum = innerSum;
                                maxInnerRow = row;
                                maxInnerCol = col;
                            }
                        }*/
                    }
                }
            }


            for (int maxRow = 0; maxRow < innerSquareMatrixRows; maxRow++)
            {
                for (int maxCol = 0; maxCol < innerSquareMatrixCols; maxCol++)
                {
                    Console.Write($"{numMatrix[maxRow + maxInnerRow, maxCol + maxInnerCol]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine(maxSum);
        }
    }
}
