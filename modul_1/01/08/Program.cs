using System;

namespace _08
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            double result = 1;
            if (type == "Premiere") result = 12;
            else if (type == "Normal") result = 7.50;
            else if (type == "Discount") result = 5;
            result *= r * c;
            Console.WriteLine("{0:f2}", result);


        }
    }
}
