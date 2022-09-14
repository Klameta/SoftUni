using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam._05
{
    class Program
    {
        static void Main(string[] args)
        {
            int nLocations = int.Parse(Console.ReadLine());
            double averageGold = 0;
            int days = 0;
            double goldForday = 0;
            double goldsum = 0;
            double gavr = 0;

            for (int i = 0; i < nLocations; i++)
            {
                averageGold = double.Parse(Console.ReadLine());

                days = int.Parse(Console.ReadLine());
                for (int k = 0; k < days; k++)
                {
                    goldForday = double.Parse(Console.ReadLine());

                    goldsum += goldForday;
                    
                }
                gavr = goldsum / days;
                if (gavr>=averageGold)
                {
                    Console.WriteLine($"Good job! Average gold per day: {goldsum/days:F2}.");
                    goldsum = 0;
                    gavr = 0;
                }
                else
                {
                    Console.WriteLine($"You need {(averageGold- goldsum/days):F2} gold.");
                }
            }


        }
    }
}
