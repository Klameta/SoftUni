using System;
using System.Linq;
namespace _06.JaggedArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            long[][] numJagged = new long[rows][];

            ReadingJaggedArray(rows, numJagged);

            MultiplyingDividing(rows, numJagged);

            AddingSubtracting(rows, numJagged);

            WritingMatrix(rows, numJagged);
        }

        private static void MultiplyingDividing(int rows, long[][] numJagged)
        {
            for (int row = 0; row < rows - 1; row++)
            {
                bool multiply = false;
                if (numJagged[row].Count() == numJagged[row + 1].Count())
                {
                    multiply = true; ;
                }

                for (int col1 = 0; col1 < numJagged[row].Count(); col1++)
                {
                    DivideOrMultiply(numJagged, row, multiply, col1);
                }

                int currRow = row + 1;
                for (int col2 = 0; col2 < numJagged[row + 1].Count(); col2++)
                {
                    DivideOrMultiply(numJagged, currRow, multiply, col2);
                }
            }
        }

        private static void ReadingJaggedArray(int rows, long[][] numJagged)
        {
            for (int row = 0; row < rows; row++)
            {
                long[] inputCols = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToArray();
                numJagged[row] = inputCols;
            }
        }

        private static void AddingSubtracting(int rows, long[][] numJagged)
        {
            string[] cmdArgs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            while (cmdArgs[0] != "End")
            {
                int row = int.Parse(cmdArgs[1]);
                int col = int.Parse(cmdArgs[2]);
                int value = int.Parse(cmdArgs[3]);
                if (row < rows && row >= 0 && col >= 0)
                {
                    if (col < numJagged[row].Count())
                    {

                        switch (cmdArgs[0])
                        {
                            case "Add":
                                numJagged[row][col] += value;
                                break;
                            case "Subtract":
                                numJagged[row][col] -= value;
                                break;
                        }
                    }
                }
                cmdArgs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            }
        }

        private static void WritingMatrix(int rows, long[][] numJagged)
        {
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < numJagged[row].Count(); col++)
                {
                    Console.Write(numJagged[row][col] + " ");
                }
                Console.WriteLine();
            }
        }

        private static void DivideOrMultiply(long[][] numJagged, int row, bool multiply, int col)
        {
            if (multiply)
            {
                numJagged[row][col] *= 2;
            }
            else
            {
                double curr = numJagged[row][col];
                numJagged[row][col] = (long)Math.Ceiling(curr / 2.00);
            }
        }
    }
}
