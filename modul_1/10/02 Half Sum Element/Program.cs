using System;

namespace _02_Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int nInput = int.Parse(Console.ReadLine());
            int maxNum = int.MinValue;
            int sum = 0;
            for (int i = 0; i < nInput; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum += num;
                if (num>maxNum)
                {
                    maxNum = num;
                }
                
            }
            int diff = Math.Abs(sum - maxNum);
            if (diff==maxNum)
            {
                Console.WriteLine($"Yes");
                Console.WriteLine($"Sum = {maxNum}");
            }
            else
            {
                Console.WriteLine($"No");
                Console.WriteLine($"Diff = {Math.Abs(maxNum-diff)}");
            }
        }
    }
}
