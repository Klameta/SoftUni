using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_FromLeftToTheRight
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            while (num > 0)
            {
                long sumOfDigits = 0;
                List<long> commandArgs = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
                if (commandArgs[0] >= commandArgs[1])
                {
                    long leftNum = commandArgs[0];
                    while (leftNum!=0)
                    {
                        long currentDigit = leftNum % 10;
                        leftNum /= 10;
                        sumOfDigits += currentDigit;
                    }
                    Console.WriteLine(Math.Abs(sumOfDigits));
                }
                else
                {
                    long rightNum = commandArgs[1];
                    while (rightNum != 0)
                    {
                        long currentDigit = rightNum % 10;
                        rightNum /= 10;
                        sumOfDigits += currentDigit;
                    }
                    Console.WriteLine(Math.Abs(sumOfDigits));
                }
                num--;
            }
        }
    }
}
