using System;

namespace _03_07_13._01._2022
{
    class Program
    {
        static void Main(string[] args)
        {
            int nC = int.Parse(Console.ReadLine());
            int nF = int.Parse(Console.ReadLine());
            int nV = int.Parse(Console.ReadLine());

            double sC = nC * 10.35;
            double sF = nF * 12.40;
            double sV = nV * 8.15;
            double sM = sC + sF + sV;
            double sD = sM * 0.2;
            double LastSum = sD + 2.50 + sM;
            Console.WriteLine($"{LastSum}");
            
        }
    }
}
