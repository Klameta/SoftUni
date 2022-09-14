using System;

namespace _01_MetersToKilometers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int meters = int.Parse(Console.ReadLine());

            double kilometers = meters / 1000.00;

            Console.WriteLine($"{kilometers:f2}");
        }
    }
}
