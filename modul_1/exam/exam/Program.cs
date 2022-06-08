using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int priceGraphicCard = int.Parse(Console.ReadLine());
            int prehodnik = int.Parse(Console.ReadLine());
            double elec = double.Parse(Console.ReadLine());
            double payment = double.Parse(Console.ReadLine());

            int pGraphic = priceGraphicCard * 13;
            int pPred = prehodnik * 13;
            int moneySpend = pGraphic + pPred + 1000;
            double perDay = payment - elec;
            double paymentSum = 13 * perDay;
            double sum = moneySpend / paymentSum;
            Console.WriteLine(moneySpend);
            Console.WriteLine(Math.Ceiling(sum));


        }

    }
}
