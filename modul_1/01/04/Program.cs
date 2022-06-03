using System;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            int moneyTotal = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int nFishers = int.Parse(Console.ReadLine());
            double price = 1.00;

            switch (season)
            {
                case "Spring":
                    price = 3000;
                    break;
                case "Summer":
                case "Autumn":
                    price = 4200;
                    break;
                case "Winter":
                    price = 2600;
                    break;
            }

            if (nFishers<=6)
            {
                price = price - price* 0.1;
            }
            else if (nFishers<=11)
            {
                price =price-price* 0.15;
            }
            else if (nFishers>=12)
            {
                price =price - price* 0.25;
            }

            if (nFishers%2==0 && season != "Autumn")
            {
                price =price-price* 0.05;
            }

            if (moneyTotal>=price)
            {
                Console.WriteLine($"Yes! You have {moneyTotal-price:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {price-moneyTotal:F2} leva.");
            }
        }
    }
}
