using System;
using System.Linq;
namespace _04.MatrixShuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimentions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = dimentions[0];
            int cols = dimentions[1];
            string[,] strMatrix = new string[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                for (int col = 0; col < cols; col++)
                {
                    strMatrix[row, col] = input[col];
                }
            }

            string[] cmdArgs = Console.ReadLine().Split();
            while (cmdArgs[0] != "END")
            {
                if (cmdArgs[0] != "swap" || cmdArgs.Length != 5)
                {
                    Console.WriteLine("Invalid input!");
                }
                else if (cmdArgs.Length == 5)
                {
                    int row1 = int.Parse(cmdArgs[1]);
                    int col1 = int.Parse(cmdArgs[2]);
                    int row2 = int.Parse(cmdArgs[3]);
                    int col2 = int.Parse(cmdArgs[4]);
                    if (row1 > rows || row2 > rows || col1 > cols || col2 > cols)
                    {
                        Console.WriteLine("Invalid input!");

                    }
                    else
                    {
                        string temp = strMatrix[row1, col1];
                        strMatrix[row1, col1] = strMatrix[row2, col2];
                        strMatrix[row2, col2] = temp;

                        for (int row = 0; row < rows; row++)
                        {
                            for (int col = 0; col < cols; col++)
                            {
                                Console.Write(strMatrix[row, col] + " ");
                            }
                            Console.WriteLine();
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }

                cmdArgs = Console.ReadLine().Split();
            }
        }
    }
}
