using System;

namespace _01_01_09_01_2022
{
    class Program
    {
        static void Main(string[] args)
        {
            int sideA = int.Parse(Console.ReadLine());
            int sideB = int.Parse(Console.ReadLine());
            int sum = sideA * sideB;
            Console.WriteLine($"{sum}");
        }
    }
}
