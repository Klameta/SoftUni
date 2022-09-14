using System;

namespace _12_RefactorSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNum = int.Parse(Console.ReadLine());

            for (int i = 1; i <= inputNum; i++)
            {
                int currentNum = i;
                int sum = 0;
                while (currentNum > 0)
                {
                    sum += currentNum % 10;
                    currentNum = currentNum / 10;
                }

                bool trueOrFalse = sum == 5 ? true : sum == 7 ? true : sum == 11 ? true : false;

                Console.WriteLine($"{i} -> {trueOrFalse}");
            }

        }
    }
}
