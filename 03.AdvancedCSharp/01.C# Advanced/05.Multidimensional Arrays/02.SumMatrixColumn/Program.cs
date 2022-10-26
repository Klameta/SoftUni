using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.SumMatrixColumn
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = input[0];
            int cols = input[1];
            int[,] numMatrix = new int[rows, cols];
            int sum = 0;

            for (int i = 0; i < rows; i++)
            {
                int[] inputMatrix = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

                for (int k = 0; k < cols; k++)
                {
                    numMatrix[i, k] = inputMatrix[k];
                    sum += numMatrix[k, i];
                }
                Console.WriteLine(sum);
                sum = 0;
            }

           /* for (int i = 0; i < cols; i++)
            {
                for (int k = 0; k < rows; k++)
                {
                    sum += numMatrix[k, i];
                }
                Console.WriteLine(sum);
                sum = 0;
            }*/
        }
    }
}
