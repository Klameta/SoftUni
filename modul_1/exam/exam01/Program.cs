using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam01
{
    class Program
    {
        static void Main(string[] args)
        {
            int nprocesori = int.Parse(Console.ReadLine());
            int slujiteli = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            int hoursSum = 8 * slujiteli * days;
            double cpu = Math.Floor((double)hoursSum / 3);

            if (cpu<nprocesori)
            {
                cpu = nprocesori - cpu;
                Console.WriteLine($"Losses: -> {(double)cpu*110.10:F2} BGN");
            }
            else
            {
                cpu = cpu - nprocesori;
                Console.WriteLine($"Profit: -> {(double)cpu*110.10:F2} BGN");
            }
        }
    }
}
