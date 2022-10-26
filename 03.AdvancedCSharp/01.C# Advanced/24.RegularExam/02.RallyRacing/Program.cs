using System;

namespace _02.RallyRacing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rowsCols = int.Parse(Console.ReadLine());
            string[,] raceRoute = new string[rowsCols, rowsCols];
            string carNumber = Console.ReadLine();
            int firstTunnelRow = 0;
            int firstTunnelCol = 0;
            int secondTunnelRow = 0;
            int secondTunnelCol = 0;
            bool firstSecond = true;

            for (int row = 0; row < rowsCols; row++)
            {
                string[] currRow = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                for (int col = 0; col < rowsCols; col++)
                {
                    raceRoute[row, col] = currRow[col];

                    if (currRow[col] == "T" && firstSecond)
                    {
                        firstTunnelRow = row;
                        firstTunnelCol = col;
                        firstSecond = false;
                    }
                    else if (currRow[col] == "T")
                    {
                        secondTunnelRow = row;
                        secondTunnelCol = col;
                    }
                }
            } //reading

            string cmdArgs = Console.ReadLine();
            int carRow = 0;
            int carCol = 0;

            int totalDistance = 0;
            bool finished = false;

            while (cmdArgs != "End")
            {

                if (finished)
                {
                    break;
                }

                switch (cmdArgs)
                {
                    case "up":
                        carRow--;
                        break;
                    case "right":
                        carCol++;
                        break;
                    case "down":
                        carRow++;
                        break;
                    case "left":
                        carCol--;
                        break;
                }

                if (raceRoute[carRow, carCol] == "T")
                {
                    Tunnels(ref raceRoute, ref carRow, ref carCol, firstTunnelRow, firstTunnelCol, secondTunnelRow, secondTunnelCol, ref totalDistance);
                }
                else if (raceRoute[carRow, carCol] == "F")
                {
                    finished = true;
                    totalDistance += 10;
                }
                else
                {
                    totalDistance += 10;
                }
                cmdArgs = Console.ReadLine();
            }

            if (finished)
            {
                Console.WriteLine($"Racing car {carNumber} finished the stage!");
            }
            else
            {
                Console.WriteLine($"Racing car {carNumber} DNF.");
            }

            Console.WriteLine($"Distance covered {totalDistance} km.");
            raceRoute[carRow, carCol] = "C";

            PrintMatrix(raceRoute);
        }
        static void Tunnels(ref string[,] raceTrack, ref int currRow, ref int currCol, int firstTunnelRow, int firstTunnelCol, int secondTunnelRow, int secondTunnelCol, ref int totalDistance)
        {
            bool isFirst = currRow == firstTunnelRow && currCol == firstTunnelCol;

            if (isFirst)
            {
                currRow = secondTunnelRow;
                currCol = secondTunnelCol;
            }
            else
            {
                currRow = firstTunnelRow;
                currCol = firstTunnelCol;
            }

            raceTrack[firstTunnelRow, firstTunnelCol] = ".";
            raceTrack[secondTunnelRow, secondTunnelCol] = ".";


            totalDistance += 30;
        }

        private static void PrintMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }

                Console.WriteLine();
            }
        }
    }
}
