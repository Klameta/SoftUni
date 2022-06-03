using System;

namespace _08_09_Ski_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string typeStay = Console.ReadLine();
            string grade = Console.ReadLine();
            double price = 0.00;
            int nights = days - 1;

            switch (typeStay)
            {
                case "room for one person":
                    price = nights * 18.00;
                    break;
                case "apartment":
                    price = nights * 25.00;
                    if (days < 10)
                    {
                        price = price - price * 0.30;
                    }
                    else if (days <= 15)
                    {
                        price = price - price * 0.35;
                    }
                    else
                    {
                        price = price - price * 0.50;
                    }
                    break;
                case "president apartment":
                    price = nights * 35.00;
                    if (days < 10)
                    {
                        price = price - price * 0.10;
                    }
                    else if (days <= 15)
                    {
                        price = price - price * 0.15;
                    }
                    else
                    {
                        price = price - price * 0.20;
                    }
                    break;
            }
            if (grade=="positive")
            {
                price = price + price * 0.25;
            }
            else
            {
                price = price - price * 0.10;
            }
            Console.WriteLine($"{price:F2}");
        }
    }
}
