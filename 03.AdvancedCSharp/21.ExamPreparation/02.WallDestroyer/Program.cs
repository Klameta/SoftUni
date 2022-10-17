using System;

namespace _02.WallDestroyer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rowsCols = int.Parse(Console.ReadLine());
            char[,] wall = new char[rowsCols, rowsCols];
            int startingRow = 0;
            int startingCol = 0;
            int holeCounter = 0;

            Reading(rowsCols, wall, ref startingRow, ref startingCol, ref holeCounter);

            string direction = Console.ReadLine();
            bool electrocuted = false;
            int rodCounter = 0;

            while (true)
            {
                if (direction == "End" || electrocuted)
                {
                    break;
                }

                Move(ref startingCol, ref startingRow, ref wall, direction, ref electrocuted, ref rodCounter, ref holeCounter);


                direction = Console.ReadLine();
            }

            if (electrocuted)
            {
                Console.WriteLine($"Vanko got electrocuted, but he managed to make {holeCounter} hole(s).");
            }
            else
            {
                Console.WriteLine($"Vanko managed to make {holeCounter} hole(s) and he hit only {rodCounter} rod(s).");
            }

            Writing(rowsCols, wall);

        }


        public static void Move(ref int currCol, ref int currRow, ref char[,] wall, string direction, ref bool electecuted, ref int rodCounter, ref int holeCounter)
        {
            int destinationCol = currCol;
            int destinationRow = currRow;

            switch (direction)
            {
                case "up":
                    destinationRow--;

                    break;
                case "right":
                    destinationCol++;

                    break;
                case "down":
                    destinationRow++;

                    break;
                case "left":
                    destinationCol--;

                    break;
            }

            if (CheckIndex(destinationCol, destinationRow, wall))
            {
                if (wall[destinationRow, destinationCol] == 'R')
                {
                    Console.WriteLine("Vanko hit a rod!");
                    destinationCol = currCol;
                    destinationRow = currRow;

                    rodCounter++;
                }
                else if (wall[destinationRow, destinationCol] == 'C')
                {
                    electecuted = true;
                    holeCounter++;
                }
                else if (wall[destinationRow, destinationCol] == '*' || wall[destinationRow, destinationCol] == 'V')
                {
                    Console.WriteLine($"The wall is already destroyed at position [{destinationRow}, {destinationCol}]!");

                }
                else
                {
                    wall[destinationRow, destinationCol] = '*';
                    holeCounter++;
                }
                wall[currRow, currCol] = '*';
                currRow = destinationRow;
                currCol = destinationCol;

                if (electecuted) wall[currRow, currCol] = 'E';
                else wall[currRow, currCol] = 'V';
            }
        }
        public static bool CheckIndex(int currCol, int currRow, char[,] wall)
        {
            return currCol >= 0 && currRow >= 0
                && currCol < wall.GetLength(0) && currRow < wall.GetLength(1);
        }

        private static void Reading(int rowsCols, char[,] wall, ref int startingRow, ref int startingCol, ref int holeCounter)
        {
            for (int row = 0; row < rowsCols; row++)
            {
                char[] inputWall = Console.ReadLine().ToCharArray();
                for (int col = 0; col < rowsCols; col++)
                {
                    wall[row, col] = inputWall[col];
                    if (wall[row, col] == 'V')
                    {
                        startingRow = row;
                        startingCol = col;
                        holeCounter++;
                    }

                }
            }
        }
        private static void Writing(int rowsCols, char[,] wall)
        {
            for (int col = 0; col < rowsCols; col++)
            {
                for (int row = 0; row < rowsCols; row++)
                {
                    Console.Write($"{wall[col, row]}");
                }
                Console.WriteLine();
            }
        }
    }
}
