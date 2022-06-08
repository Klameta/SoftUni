using System;

namespace _03_01_09._01._2022
{
    class Program
    {
        static void Main(string[] args)
        
        {
            double USD = double.Parse(Console.ReadLine());
            double BGN = USD * 1.79549;
            Console.WriteLine($"{BGN}");
        }
    }
}
