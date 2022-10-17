using System;

namespace _02.WallDestroyer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rowsCols = int.Parse(Console.ReadLine());
            char[,] wall = new char[rowsCols, rowsCols];

            for (int row = 0; row < rowsCols; row++)
            {
                char[] inputWall = Console.ReadLine().ToCharArray();
                for (int col = 0; col < rowsCols; col++)
                {
                    wall[row, col] = inputWall[col];
                }
            }

            string direction = Console.ReadLine();
            bool electrocuted = false;

            while (true)
            {
                if (direction == "End" || electrocuted)
                {
                    break;
                }



                direction = Console.ReadLine();
            }


        }
        public static bool CheckIndex(int currCol, int currRow, char[,] wall)
        {
            return currCol >= 0 && currRow >= 0
                && currCol < wall.GetLength(0) && currRow < wall.GetLength(1);
        }
    }
}
