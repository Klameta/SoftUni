using System;

namespace _07_WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            const int Capacity = 255;
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                int currentLiters = int.Parse(Console.ReadLine());

                if (sum + currentLiters > Capacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    sum += currentLiters;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
