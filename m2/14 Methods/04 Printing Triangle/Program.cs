using System;

namespace _04_Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int height = int.Parse(Console.ReadLine());
            PrintTriangle(height);
        }
        static void PrintUpperTriangle(int height)
        {
            for (int k = 1; k <= height; k++)
            {
                for (int i = 1; i <= k; i++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
        }
        static void PrintLowerTriangle(int height)
        {
            for (int k = height - 1; k >= 1; k--)
            {
                for (int i = 1; i <= k; i++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
        }
        static void PrintTriangle(int height)
        {
            PrintUpperTriangle(height);
            PrintLowerTriangle(height);
        }
    }
}
