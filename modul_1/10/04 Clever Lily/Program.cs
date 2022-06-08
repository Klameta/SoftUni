using System;

namespace _04_Clever_Lily
{
    class Program
    {
        static void Main(string[] args)
        {
            int old = int.Parse(Console.ReadLine());
            double price = double.Parse(Console.ReadLine());
            int pForOne = int.Parse(Console.ReadLine());

            int evenBd = 0;
            int oddBd = 0;
            int moneySum = 0;
            int brother = 0;

            for (int i = 1; i <= old; i++)
            {
                if (i%2==0)
                {
                    evenBd+=10;
                    moneySum += evenBd;
                    brother ++;
                }
                else
                {
                    oddBd++;
                }
            }
            int finalSum = (moneySum + oddBd * pForOne) - brother;
            if (price<=finalSum)
            {
                Console.WriteLine($"Yes! {finalSum-price:F2}");
            }
            else
            {
                Console.WriteLine($"No! {price-finalSum:F2}");
            }
        }
    }
}
