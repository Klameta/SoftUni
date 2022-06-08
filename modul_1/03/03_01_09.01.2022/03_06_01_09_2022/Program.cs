using System;

namespace _03_06_01_09_2022
{
    class Program
    {
        static void Main(string[] args)
        {
            int nailon = int.Parse(Console.ReadLine());
            int paint = int.Parse(Console.ReadLine());
            int R = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());

            
            double Ln = (nailon+2) * 1.50;
            double Lp = (paint +(paint*0.1)) * 14.50;
            double Lr = R * 5.00;
            double sum = Ln + Lp + Lr + 0.40;
            double Sm = (sum * (sum*0.3)) * hours;
            double Lsum = sum + Sm;
            Console.WriteLine($"{Lsum}");
        }
    }
}
