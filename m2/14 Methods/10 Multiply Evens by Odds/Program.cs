using System;

namespace _10_Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(GetMultipleOfEvenAndOdds(num));
        }
        static int GetSumOfEvenDigits(int number)
        {
            int evenSum = 0;
            int currentNum = 0;
            number = Math.Abs(number);
            while (number != 0)
            {
                currentNum = number % 10;
                number = number / 10;
                if (currentNum % 2 == 0)
                {
                    evenSum += currentNum;
                }
            }
            return evenSum;
        }
        static int GetSumOfOddDigits(int number)
        {
            int oddSum = 0;
            int currentNum = 0;
            number = Math.Abs(number);
            while (number != 0)
            {
                currentNum = number % 10;
                number = number / 10;
                if (currentNum % 2 == 1)
                {
                    oddSum += currentNum;
                }
            }
            return oddSum;
        }
        static int GetMultipleOfEvenAndOdds(int number)
        {

            int evenSum = GetSumOfEvenDigits(number);
            int oddSum = GetSumOfOddDigits(number);
            return evenSum * oddSum;
        }

    }

}
