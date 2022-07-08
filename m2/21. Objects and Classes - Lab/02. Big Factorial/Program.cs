using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;
namespace _02._Big_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger num = new BigInteger(int.Parse(Console.ReadLine()));
            Console.WriteLine(Fact(num));
        }
        static BigInteger Fact(BigInteger num)
        {
            if (num==1)
            {
                return num;
            }
            return num *= Fact(num - 1);
        }
    }
}
