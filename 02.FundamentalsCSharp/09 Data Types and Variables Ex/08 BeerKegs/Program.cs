using System;
using System.Collections.Generic;
using System.Linq;


namespace _08_BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string biggestKeg = "";
            decimal biggestVolume = 0;

            for (int i = 0; i < n; i++)
            {
                string currentKeg = Console.ReadLine();
                decimal radius = decimal.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                decimal volume = (decimal)(Math.PI * Math.Pow((double)radius, 2) * height);

                if (volume>biggestVolume)
                {
                    biggestVolume = volume;
                    biggestKeg = currentKeg;
                }
            }
            Console.WriteLine(biggestKeg);
        }
    }
}
