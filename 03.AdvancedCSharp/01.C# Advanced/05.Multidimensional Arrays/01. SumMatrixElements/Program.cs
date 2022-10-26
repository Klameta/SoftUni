using System;
using System.Collections.Generic;
using System.Linq;
namespace _01._SumMatrixElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = input[0];
            int cols= input[1];
            int[,] numMatric = new int[rows, cols];
            int sum=0;

            for (int i = 0; i < rows; i++)
            {
                int[] inputMatric = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int k = 0; k < cols; k++)
                {
                    numMatric[i, k] = inputMatric[k];
                    sum += inputMatric[k];
                }
            }

            Console.WriteLine($"{rows}\n{cols}\n{sum}");
        }
    }
}
