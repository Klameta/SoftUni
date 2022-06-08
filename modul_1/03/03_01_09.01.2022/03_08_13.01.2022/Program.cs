using System;

namespace _03_08_13._01._2022
{
    class Program
    {
        static void Main(string[] args)
        {
            int tax = int.Parse(Console.ReadLine());

            double trainers = tax - tax * (40/100.0);
            double fit = trainers - trainers*(20/100.0 );
            double ball = fit / 4;
            double acc = ball / 5;
            double LastSum = tax + trainers + fit + ball + acc;
            Console.WriteLine($"{LastSum}");

        }
    }
}
