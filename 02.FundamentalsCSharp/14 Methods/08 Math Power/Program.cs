using System;

namespace _08_Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            int pow = int.Parse(Console.ReadLine());
            Console.WriteLine(Power(number,pow));
        }
        static double Power(double number, int pow)
        {
            double result = 1d;
            for (int i = 0; i < pow; i++)
            {
                result *= number;
            }
            return result;
        }
    }
}
