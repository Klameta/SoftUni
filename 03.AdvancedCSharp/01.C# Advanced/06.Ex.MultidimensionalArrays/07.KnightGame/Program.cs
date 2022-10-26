using System;
using System.Linq;
namespace _07.KnightGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int rowsCols = int.Parse(Console.ReadLine());
            char[,] charMatrix = new char[rowsCols, rowsCols];

            ReadingMatrix(rowsCols, charMatrix);

            if (rowsCols < 3)
            {
                Console.WriteLine(0);
                return;
            }

            int knightsDead = 0;
            while (true)
            {
                int mostAttacking = 0;
                int rowMostAttacking = 0;
                int colMostAttacking = 0;

                for (int row = 0; row < rowsCols; row++)
                {
                    for (int col = 0; col < rowsCols; col++)
                    {
                        if (charMatrix[row, col] == 'K')
                        {

                            int currAttacking = Attacking(row, col, charMatrix, rowsCols);
                            if (currAttacking > mostAttacking)
                            {
                                rowMostAttacking = row;
                                colMostAttacking = col;
                                mostAttacking = currAttacking;
                            }
                        }
                    }
                }

                if (mostAttacking == 0)
                {
                    break;
                }
                else
                {
                    charMatrix[rowMostAttacking, colMostAttacking] = '0';
                    knightsDead++;
                }
            }
            Console.WriteLine(knightsDead);
        }

        private static int Attacking(int row, int col, char[,] charMatrix, int rowsCols)
        {
            int attacked = 0;
            if (CellValid(row - 2, col - 1, rowsCols))
            {
                if (charMatrix[row - 2, col - 1] == 'K')
                {
                    attacked++;
                }
            }

            if (CellValid(row - 2, col + 1, rowsCols))
            {
                if (charMatrix[row - 2, col + 1] == 'K')
                {
                    attacked++;
                }
            }

            if (CellValid(row - 1, col - 2, rowsCols))
            {
                if (charMatrix[row - 1, col - 2] == 'K')
                {
                    attacked++;
                }
            }

            if (CellValid(row + 1, col - 2, rowsCols))
            {
                if (charMatrix[row + 1, col - 2] == 'K')
                {
                    attacked++;
                }
            }

            if (CellValid(row + 2, col - 1, rowsCols))
            {
                if (charMatrix[row + 2, col - 1] == 'K')
                {
                    attacked++;
                }
            }

            if (CellValid(row + 2, col + 1, rowsCols))
            {
                if (charMatrix[row + 2, col + 1] == 'K')
                {
                    attacked++;
                }
            }
            return attacked;
        }
        static bool CellValid(int row, int col, int rowsCols)
        {
            return row >= 0 && col >= 0 && row < rowsCols && col < rowsCols;
        }

        private static void ReadingMatrix(int rowsCols, char[,] charMatrix)
        {
            for (int row = 0; row < rowsCols; row++)
            {
                char[] input = Console.ReadLine().ToCharArray();
                for (int col = 0; col < rowsCols; col++)
                {
                    charMatrix[row, col] = input[col];
                }
            }
        }

    }
}
