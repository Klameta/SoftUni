using System;

namespace _07_Hotel_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nNights = int.Parse(Console.ReadLine());
            double priceApt = 0.00;
            double priceStudio = 0.00;

            if (month == "May"|| month== "October")
            {
                priceApt = 65 * nNights;
                priceStudio = 50 * nNights;
                if (nNights>14)
                {
                    priceStudio = priceStudio - (priceStudio * 0.30);
                }
                else if (nNights>7)
                {
                    priceStudio = priceStudio - (priceStudio * 0.05);
                }


            }
            else if (month =="June"|| month== "September")
            {
                priceStudio = 75.20 * nNights;
                priceApt = 68.70 * nNights;

                if (nNights>14)
                {
                    priceStudio = priceStudio - (priceStudio * 0.2);

                }

            }
            else
            {
                priceStudio = 76 * nNights;
                priceApt = 77 * nNights;
            }

            if (nNights>14)
            {
                priceApt = priceApt - (priceApt * 0.1);
            }

            Console.WriteLine($"Apartment: {priceApt:F2} lv.");
            Console.WriteLine($"Studio: {priceStudio:F2} lv.");
        }
    }
}
