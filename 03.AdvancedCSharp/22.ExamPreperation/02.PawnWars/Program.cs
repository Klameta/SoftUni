using System;

namespace _02.PawnWars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[,] chessBoard = new char[8, 8];
            int blackRow = 0;
            int blackCol = 0;
            int whiteRow = 0;
            int whiteCol = 0;


            for (int row = 0; row < 8; row++)
            {
                char[] inputChess = Console.ReadLine().ToCharArray();

                for (int col = 0; col < 8; col++)
                {
                    chessBoard[row, col] = inputChess[col];
                    if (chessBoard[row, col] == 'b')
                    {
                        blackRow = row;
                        blackCol = col;
                    }
                    else if (chessBoard[row, col] == 'w')
                    {
                        whiteRow = row;
                        whiteCol = col;
                    }
                }

            }

            int promoted = -1; //0 for black promotion, 1 for white
            int capture = -1; //same here


            while (true)
            {
                if (promoted >= 0) break;
                if (capture >= 0) break;

                Move(ref blackRow, ref blackCol, ref whiteRow, ref whiteCol, chessBoard, ref promoted, ref capture);
            }
            //Console.WriteLine();

            if (promoted >= 0)
            {
                Console.WriteLine("Game over! {0} pawn is promoted to a queen at {1}.", (promoted == 0 ? "Black" : "White"), (promoted == 0 ? $"{(char)('a' + blackCol)}{8 - blackRow}" : $"{(char)('a' + whiteCol)}{8 - whiteRow}"));
            }
            else
            {
                Console.WriteLine("Game over! {0} capture on {1}.", (capture == 0 ? "Black" : "White"), (capture == 0 ? $"{(char)('a' + whiteCol)}{whiteRow}" : $"{(char)('a' + blackCol)}{8 - blackRow}"));
            }
        }
        public static void Move(ref int blackRow, ref int blackCol, ref int whiteRow, ref int whiteCol, char[,] chessboard, ref int promoted, ref int capture)
        {
            if (whiteRow - 1 == blackRow && (whiteCol - 1 == blackCol || whiteCol + 1 == blackCol))
            {
                capture = 1;
                return;
            }
            if (whiteRow > 0)
            {

                {
                    whiteRow--;

                }
            }
            else
            {
                promoted = 1;
                return;
            }

            chessboard[whiteRow + 1, whiteCol] = '-';
            chessboard[whiteRow, whiteCol] = 'w';
            //Writing(chessboard);

            if (blackRow + 1 == whiteRow && (blackCol + 1 == whiteCol || blackCol - 1 == whiteCol))
            {
                capture = 0;
                return;
            }
            if (blackRow < 7)
            {

                blackRow++;
            }
            else
            {
                promoted = 0;
                return;
            }

            chessboard[blackRow - 1, blackCol] = '-';
            chessboard[blackRow, blackCol] = 'b';
            //Writing(chessboard);

        }

        public static void Writing(char[,] chessboard)
        {
            Console.WriteLine();
            for (int i = 0; i < chessboard.GetLength(0); i++)
            {
                for (int j = 0; j < chessboard.GetLength(1); j++)
                {
                    Console.Write(chessboard[i, j]);
                }
                Console.WriteLine();
            }
        }
    }

}
