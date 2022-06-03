using System;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            var flowerType = Console.ReadLine();
            var n = int.Parse(Console.ReadLine());
            var MoneyTotal = int.Parse(Console.ReadLine());
            var price = 1.00;
            switch (flowerType)
            {
                case "Roses":
                    price = n * 5;
                    if (n>80)
                    {
                        price =price-price* 0.1;
                    }
                    break;
                case "Dahlias":
                    price = n * 3.80;
                    if (n>90)
                    {
                        price =price- price* 0.15;
                    }
                    break;
                case "Tulips":
                    price = n * 2.80;
                    if (n>80)
                    {
                        price =price -price* 0.15;
                    }
                    break;
                case "Narcissus":
                    price = n * 3;
                    if (n<120)
                    {
                        price = price +(price*0.15);
                    }
                    break;
                    
                default:
                    price = n * 2.50;
                    if (n<80)
                    {
                        price = price + (price * 0.20);
                    }

                    break;
            }
            if (MoneyTotal>=price)
            {
                Console.WriteLine($"Hey, you have a great garden with {n} {flowerType} and {MoneyTotal-price, 0:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {price -MoneyTotal, 0:F2} leva more.");
            }


        }
    }
}
