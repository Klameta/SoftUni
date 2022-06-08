using System;

namespace _03_04_01._09._2022
{
    class Program
    {
        static void Main(string[] args)
        {
            int pages = int.Parse(Console.ReadLine());
            int pph = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int sum = (pages / pph) / days;
            Console.WriteLine($"{sum}");
        }
    }
}
