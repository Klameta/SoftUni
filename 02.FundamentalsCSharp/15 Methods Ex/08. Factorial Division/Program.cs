using System;

namespace _08._Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());

            Console.WriteLine($"{Division(first,second):F2}");
        }
        static double Factorial(int number)
        {
            double sum = 1;
            for (int i = 1; i <= number; i++)
            {
                sum *= i;
            }
            return sum;
        }
        static double Division(int first, int second)
        {
            double firstFact = Factorial(first); 
            double secondFact = Factorial(second);

            return firstFact / secondFact;
        }
    }
}
