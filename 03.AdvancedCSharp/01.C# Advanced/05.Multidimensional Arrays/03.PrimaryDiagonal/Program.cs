using System;
using System.Linq;
using System.Collections.Generic;

namespace _03.PrimaryDiagonal
{

    class Program
    {
        static void Main(string[] args)
        {
            int rowsCols = int.Parse(Console.ReadLine());
            int[,] squareMatrix = new int[rowsCols, rowsCols];
            int sumCounter = 0;
            int sum = 0;

            for (int i = 0; i < rowsCols; i++)
            {
                int[] inputMatrix = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int k = 0; k < rowsCols; k++)
                {
                    squareMatrix[i, k] = inputMatrix[k];

                }
                sum += squareMatrix[sumCounter, sumCounter];
                sumCounter++;
            }
            Console.WriteLine(sum);
        }
    }
}
