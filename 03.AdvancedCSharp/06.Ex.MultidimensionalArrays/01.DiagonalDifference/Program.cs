using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int rowsCols = int.Parse(Console.ReadLine());
            int[,] squareMatrix = new int[rowsCols, rowsCols];

            for (int row = 0; row < rowsCols; row++)
            {
                int[] input = Console.ReadLine()
                    .Split()
                    .Select(n => int.Parse(n))
                    .ToArray();
                for (int col = 0; col < rowsCols; col++)
                {
                    squareMatrix[row, col] = input[col];
                }
            }
            int leftRightSum = 0;
            int rightLeftSum = 0;

            for (int leftRight = 0, rightLeft = rowsCols - 1; leftRight < rowsCols; leftRight++, rightLeft--)
            {
                leftRightSum += squareMatrix[leftRight, leftRight];
                rightLeftSum += squareMatrix[leftRight, rightLeft];
            }

            Console.WriteLine($"{Math.Abs(leftRightSum - rightLeftSum)}");
        }
    }
}
