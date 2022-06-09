using System;

namespace _05_SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                int currentNum = i;
                int sumOfDigits = 0;
                while (currentNum > 0)
                {
                    sumOfDigits += currentNum % 10;
                    currentNum /= 10;
                }

                bool decision = sumOfDigits == 5 ? true : sumOfDigits == 7 ? true : sumOfDigits == 11 ? true : false;

                Console.WriteLine($"{i} -> {decision}");

            }
        }
    }
}
