using System;
using System.Linq;
using System.Collections;

namespace _03.MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimentions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = dimentions[0];
            int cols = dimentions[1];
            int[,] numMatrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    numMatrix[row, col] = input[col];
                }
            }

            int innerCols = 0;
            int innerRows = 0;
            int maxSum = int.MinValue;

            for (int row = 0; row < rows - 2; row++)
            {
                for (int col = 0; col < cols - 2; col++)
                {

                    int currSum = numMatrix[row, col]
                            + numMatrix[row + 1, col]
                            + numMatrix[row + 2, col]
                            + numMatrix[row, col + 1]
                            + numMatrix[row, col + 2]
                            + numMatrix[row + 1, col + 1]
                            + numMatrix[row + 1, col + 2]
                            + numMatrix[row + 2, col + 1]
                            + numMatrix[row + 2, col + 2];

                    if (currSum > maxSum)
                    {
                        maxSum = currSum;
                        innerCols = col;
                        innerRows = row;
                    }
                }
            }
            Console.WriteLine($"Sum = {maxSum}");

            for (int row = innerRows; row < innerRows + 3; row++)
            {
                for (int col = innerCols; col < innerCols + 3; col++)
                {
                    Console.Write(numMatrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
