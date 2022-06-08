using System;

namespace _03_09_13._01._2022
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            int S = length * width * height;
            double Sl = S / 1000.00;
            double Pl = percent / 100.00;
            double LastSum = Sl * (1 - Pl);

            Console.WriteLine($"{LastSum}");
        }
    }
}
