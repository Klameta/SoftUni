using System;

namespace _03_05_01._09._2022
{
    class Program
    {
        static void Main(string[] args)
        {
            double himikalki = double.Parse(Console.ReadLine());
            double markers = double.Parse(Console.ReadLine());
            double L = double.Parse(Console.ReadLine());
            double P = double.Parse(Console.ReadLine());
            double Sh = himikalki * 5.80;
            double Sm = markers * 7.20;
            double Sl = L * 1.20;
            double sum = (Sh + Sm + Sl);
            double Lsum = sum - (sum * (P / 100));
            Console.WriteLine($"{Lsum}");
        }
    }
}
