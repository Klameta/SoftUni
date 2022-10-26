using System;

namespace _02.PawnWars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[,] chessBoard = new char[8, 8];

            for (int row = 0; row < 8; row++)
            {
                char[] inputChess = Console.ReadLine().ToCharArray();

                for (int col = 0; col < 8; col++)
                {
                    chessBoard[row,col] = inputChess[col];
                }
            }
            Console.WriteLine();
        }
    }
}
