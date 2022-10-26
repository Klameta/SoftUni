using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Jagged_ArrayModification
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int[][] jaggedArr = new int[rows][];

            for (int i = 0; i < rows; i++)
            {
                jaggedArr[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();
            }

            string[] cmdArgs = Console.ReadLine().Split();

            while (cmdArgs[0] != "END")
            {
                switch (cmdArgs[0])
                {
                    case "Add":
                        int row = int.Parse(cmdArgs[1]);
                        int col = int.Parse(cmdArgs[2]);
                        int value = int.Parse(cmdArgs[3]);

                        bool valid = true;
                        valid = CheckCords(rows, jaggedArr, row, col, valid);

                        if (valid)
                        {
                            jaggedArr[row][col] += value;
                        }
                        break;
                    case "Subtract":
                        row = int.Parse(cmdArgs[1]);
                        col = int.Parse(cmdArgs[2]);
                        value = int.Parse(cmdArgs[3]);

                        valid = true;
                        valid = CheckCords(rows, jaggedArr, row, col, valid);

                        if (valid)
                        {
                            jaggedArr[row][col] -= value;
                        }
                        break;
                }
                cmdArgs = Console.ReadLine().Split();
            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < jaggedArr[row].Count(); col++)
                {
                    Console.Write($"{jaggedArr[row][col]} ");
                }
                Console.WriteLine();
            }
        }

        private static bool CheckCords(int rows, int[][] jaggedArr, int row, int col, bool valid)
        {
            if (row > rows - 1 || row < 0)
            {
                Console.WriteLine("Invalid coordinates");
                valid = false;
            }
            else if (col > jaggedArr[row].Count() - 1 || col < 0)
            {
                Console.WriteLine("Invalid coordinates");
                valid = false;
            }

            return valid;
        }
    }
}
