using System;
using System.Linq;
namespace _05.SnakeMoves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimentions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = dimentions[0];
            int cols = dimentions[1];
            char[,] charMatrix = new char[rows, cols];
            char[] snake = Console.ReadLine().ToCharArray();
            int indexOfSnake = 0;

            for (int row = 0; row < rows; row++)
            {
                if (row % 2 != 0)
                {
                    for (int col = cols - 1; col >= 0; col--)
                    {
                        SnakePath(charMatrix, snake, ref indexOfSnake, row, col);
                    }
                }
                else
                {
                    for (int col = 0; col < cols; col++)
                    {
                        SnakePath(charMatrix, snake, ref indexOfSnake, row, col);
                    }
                }
            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(charMatrix[row,col]);
                }
                Console.WriteLine();
            }
        }

        private static void SnakePath(char[,] charMatrix, char[] snake, ref int indexOfSnake, int row, int col)
        {
            charMatrix[row, col] = snake[indexOfSnake];
            indexOfSnake++;
            if (indexOfSnake == snake.Length)
            {
                indexOfSnake = 0;
            }

        }
    }
}
