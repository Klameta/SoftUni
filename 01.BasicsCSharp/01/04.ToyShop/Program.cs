using System;

namespace _05_03_13._01._2022
{
    class Program
    {
        static void Main(string[] args)
        {
            double sMoney = double.Parse(Console.ReadLine());

            int nPuzzle = int.Parse(Console.ReadLine());
            int nDoll = int.Parse(Console.ReadLine());
            int nBear = int.Parse(Console.ReadLine());
            int nMinion = int.Parse(Console.ReadLine());
            int nTruck = int.Parse(Console.ReadLine());

            double sale = 0.00;
            double LastSum = 0.00;

            double sum = nPuzzle * 2.60 + nDoll * 3 + nBear * 4.10 + nMinion * 8.20 + nTruck * 2;
            int sToys = nTruck + nDoll + nPuzzle + nMinion + nBear;

            if (sToys >= 50)
            {
                sum -= sum * 0.25;
            }
            sum -= sum * 0.1;

            if (sMoney<=sum)
            {
                Console.WriteLine($"Yes! {sum-sMoney:F2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {sMoney-sum:F2} lv needed.");
            }
        }
    }
}
