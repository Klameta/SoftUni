using System;
using System.Collections.Generic;
using System.Linq;

namespace o4.SymbolInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int rowsCols = int.Parse(Console.ReadLine());
            char[,] squareCharMatrix = new char[rowsCols, rowsCols];

            for (int i = 0; i < rowsCols; i++)
            {
                char[] input = Console.ReadLine().ToCharArray();
                for (int k = 0; k < rowsCols; k++)
                {
                    squareCharMatrix[i, k] = input[k];
                }
            }

            char searchSymbol = char.Parse(Console.ReadLine());
            string cords = string.Empty;
            for (int i = 0; i < rowsCols; i++)
            {
                for (int k = 0; k < rowsCols; k++)
                {
                    if (squareCharMatrix[i, k] == searchSymbol)
                    {
                        cords = $"({i}, {k})";
                    }
                }
            }

            if (cords!=string.Empty)
            {
                Console.WriteLine(cords);
            }
            else
            {
                Console.WriteLine($"{searchSymbol} does not occur in the matrix");
            }
        }
    }
}
