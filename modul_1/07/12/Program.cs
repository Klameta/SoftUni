using System;

namespace _12
{
    class Program
    {
        static void Main(string[] args)
        {
            var City = Console.ReadLine();
            var S = double.Parse(Console.ReadLine());
            var price = 0.00;
            var error = 0;

            switch (City)
            {
                case "Sofia":
                    if (S >= 0 && S <= 500)
                    {
                        price = S * 0.05;
                    }
                    else if (S >= 0 && S <= 1000)
                    {
                        price = S * 0.07;
                    }
                    else if (S >= 0 && S <= 10000)
                    {
                        price = S * 0.08;
                    }
                    else if (S >= 0 && S > 10000)
                    {
                        price = S * 0.12;
                    }
                    else
                    {
                        Console.WriteLine("error");
                        error++;
                    }
                    break;
                case "Varna":
                    if (S >= 0 && S <= 500)
                    {
                        price = S * 0.045;
                    }
                    else if (S >= 0 && S <= 1000)
                    {
                        price = S * 0.075;
                    }
                    else if (S >= 0 && S <= 10000)
                    {
                        price = S * 0.10;
                    }
                    else if (S >= 0 && S > 10000)
                    {
                        price = S * 0.13;
                    }
                    else
                    {
                        Console.WriteLine("error");
                        error++;
                    }
                    break;

                case "Plovdiv":
                    if (S >= 0 && S <= 500)
                    {
                        price = S * 0.055;
                    }
                    else if (S >= 0 && S <= 1000)
                    {
                        price = S * 0.08;
                    }
                    else if (S >= 0 && S <= 10000)
                    {
                        price = S * 0.12;
                    }
                    else if (S >= 0 && S > 10000)
                    {
                        price = S * 0.145;
                    }
                    else
                    {
                        Console.WriteLine("error");
                        error++;
                    }
                    break;
                default:
                    Console.WriteLine("error");
                    error++;
                    break;
            }
            if (error == 0)
            {
                Console.WriteLine($"{price:F2}");
            }
        }
    }
}
