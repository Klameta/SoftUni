using System;
using System.Linq;

namespace _02.SquaresInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rowsCols = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int rows = rowsCols[0];
            int cols = rowsCols[1];

            char[,] charMatrix = new char[rows, cols];

            for (int row = 0; row < charMatrix.GetLength(0); row++)
            {
                char[] input = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();

                for (int col = 0; col < charMatrix.GetLength(1); col++)
                {
                    charMatrix[row, col] = input[col];
                }
            }
            int matches = 0;

            if (rows > 1 && cols > 1)
            {

                for (int row = 0; row < charMatrix.GetLength(0)-1; row++)
                {
                    for (int col = 0; col < charMatrix.GetLength(1)- 1; col++)
                    {
                        if (charMatrix[row, col] == charMatrix[row + 1, col]
                            && charMatrix[row, col] == charMatrix[row, col + 1]
                            && charMatrix[row, col] == charMatrix[row + 1, col + 1])
                        {
                            matches++;
                        }
                    }
                }
            }
            Console.WriteLine(matches);

        }
    }
}
