using System;

namespace _05_Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int timesOrderesd = int.Parse(Console.ReadLine());
            Console.WriteLine($"{Order(product,timesOrderesd):F2}");
        }
        static double Order(string product, int timesOrdered)
        {
            double price = product == "coffee" ? 1.50 : product == "water" ? 1.00 : product == "coke" ? 1.40 : 2.00;
            return price * timesOrdered;
        }
    }
}
