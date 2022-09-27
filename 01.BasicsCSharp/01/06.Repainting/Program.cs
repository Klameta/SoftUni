using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Repainting
{
    class Program
    {
        static void Main(string[] args)
        {
            int foilNeeded = int.Parse(Console.ReadLine());
            int paintNeededL = int.Parse(Console.ReadLine());
            int thinnerNeededL = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());

            double foilPrice= (foilNeeded+2)*1.50;
            double paintPrice = (paintNeededL + ((double)paintNeededL * 0.1))*14.50;
            double thinnerPrice = thinnerNeededL * 5.00;

            double sum = foilPrice + paintPrice + thinnerPrice + 0.40;
            sum = sum + (sum * 0.3) * hours;
             
            Console.WriteLine($"Total expenses: {sum:F2} lv.");
        }
    }
}
