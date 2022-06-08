using System;

namespace _03_02_01._09._2022
{
    class Program
    {
        static void Main(string[] args)
        {
            double Fsum = double.Parse(Console.ReadLine());
            int time = int.Parse(Console.ReadLine());
            double P = double.Parse(Console.ReadLine());
            double Preal = P / 100;
            double sum = Fsum + time * ((Fsum * Preal) / 12);
            Console.WriteLine($"{sum}");
        }
    }
}
