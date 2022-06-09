using System;

namespace _01_Sign_of_Integer_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            DeclairSign(number);
        }
        static void DeclairSign(int num)
        {
            if (num<0)
            {
                Console.WriteLine($"The number {num} is negative.");
            }
            else if (num>0)
            {
                Console.WriteLine($"The number {num} is positive.");
            }
            else
            {
                Console.WriteLine($"The number {num} is zero.");
            }
        }
    }
}
