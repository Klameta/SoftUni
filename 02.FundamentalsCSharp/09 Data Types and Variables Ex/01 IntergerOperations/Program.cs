using System;

namespace _01_IntergerOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            int fourth = int.Parse(Console.ReadLine());

            int resultAdd = first + second;
            int resultDivide = (int)(resultAdd / third);
            int resultMultiply = resultDivide * fourth;

            Console.WriteLine(resultMultiply);
        }
    }
}
