using System;

namespace _06_Calculate_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            int baseA = int.Parse(Console.ReadLine());
            int baseB = int.Parse(Console.ReadLine());
            Console.WriteLine(RectangleArea(baseA,baseB));
        }
        static int RectangleArea(int baseA, int baseB)
        {
            return baseA * baseB;
        }
    }
}
