using System;

namespace _03_02_01._09_2022
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());
            double g = r * 180 / Math.PI;
            Console.WriteLine(g);
        }
    }
}
