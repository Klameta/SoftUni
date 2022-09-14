using System;

namespace _06_Stork_num
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = Console.ReadLine();
            int currentNum = 0;
            int multiSum = 1;
            int sum = 0;
            for (int i = 0; i < num.Length; i++)
            {
                currentNum = num[i] - '0';
                for (int j = 1; j <= currentNum; j++)
                {
                    multiSum *= j;
                }
                sum += multiSum;
                multiSum = 1;
            }
            Console.WriteLine(sum==int.Parse(num) ? "yes" : "no");
        }
    }
}
