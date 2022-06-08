using System;

namespace _09_08_Number_sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputN = int.Parse(Console.ReadLine());
            int MinN = int.MaxValue;
            int MaxN = int.MinValue;
            for (int i = 0; i < inputN; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num < MinN)
                {
                    MinN = num;
                }
                if (num > MaxN)
                {
                    MaxN = num;
                }
            }
            Console.WriteLine($"Max number: {MaxN}");
            Console.WriteLine($"Min number: {MinN}");


        }
    }
}
