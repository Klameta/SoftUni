using System;

namespace _01_GuiniePig
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double foodG = double.Parse(Console.ReadLine()) * 1_000;
            double hayG = double.Parse(Console.ReadLine()) * 1_000;
            double coverG = double.Parse(Console.ReadLine()) * 1_000;

            double pigG = double.Parse(Console.ReadLine()) * 1_000;

            for (int i = 1; i <= 30; i++)
            {
                foodG -= 300; //everyday feed

                if (i % 2 == 0)
                {
                    hayG = hayG - foodG * 0.05;
                }

                if (i % 3 == 0)
                {
                    coverG = coverG - pigG / 3;
                }

                if (foodG <= 0 || hayG <= 0 || coverG <= 0)
                {
                    Console.WriteLine("Merry must go to the pet store!");
                    break;
                }
            }
            if (foodG > 0 && hayG > 0 && coverG > 0)
            {
                Console.WriteLine($"Everything is fine! Puppy is happy! Food: {(foodG / 1_000):f2}, Hay: {(hayG / 1_000):f2}, Cover: {(coverG / 1_000):f2}.");
            }
        }
    }
}
