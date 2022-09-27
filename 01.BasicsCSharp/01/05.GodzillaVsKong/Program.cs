using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.GodzillaVsKong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget    = double.Parse(Console.ReadLine());
            int actors = int.Parse(Console.ReadLine());
            double pricePerActor = double.Parse(Console.ReadLine());

            budget -= budget * 0.1;
            if (actors>150)
            {
                pricePerActor -= pricePerActor * 0.1;
            }

            double sum = budget + (actors * pricePerActor);

            if (budget>=sum)
            {
                Console.WriteLine($"Action!\nWingard starts filming with {budget-sum:F2} leva more.");
            }
            else
            {
                Console.WriteLine($"Not enought money!\nWingard needs {sum - budget:F2} leva more.");
            }
        }
    }
}
