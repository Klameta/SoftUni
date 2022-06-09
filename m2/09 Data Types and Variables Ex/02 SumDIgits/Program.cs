using System;

namespace _02_SumDIgits
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            while (num > 0)
            {
                int currentNum = num;
                currentNum = num % 10;
                num /= 10;
                sum += currentNum;
            }
            Console.WriteLine(sum);
        }
    }
}
