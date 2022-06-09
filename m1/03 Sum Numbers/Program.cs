
using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int sum = 0;

            while (n>sum)
            {
                var sumToBe = int.Parse(Console.ReadLine());
                sum += sumToBe;
            }
            Console.WriteLine(sum);
        }
    }
}
