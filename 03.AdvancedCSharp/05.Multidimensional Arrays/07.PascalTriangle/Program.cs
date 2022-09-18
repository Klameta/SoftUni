using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            long rows = long.Parse(Console.ReadLine());
            long[][] jaggedArray = new long[rows][];

            for (int row = 0; row < rows; row++)
            {
                long[] colArr = new long[row + 1];
                jaggedArray[row] = colArr;
                for (int col = 0; col < row + 1; col++)
                {
                    if (col == 0 || col == row || row == 0)
                    {
                        colArr[col] = 1;
                    }
                    else
                    {
                        colArr[col] = jaggedArray[row - 1][col - 1] + jaggedArray[row - 1][col];
                    }
                }
            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < jaggedArray[row].Count(); col++)
                {
                    Console.Write($"{jaggedArray[row][col]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
