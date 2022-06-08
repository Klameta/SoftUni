using System;

namespace _04_05_13._01._2022
{
    class Program
    {
        static void Main(string[] args)
        {
            int nInput = int.Parse(Console.ReadLine());
            if (nInput<100)
            {
                Console.WriteLine($"Less than 100");
            }
            else if (nInput <=200)
            {
                Console.WriteLine($"Between 100 and 200");
            }
            else
            {
                Console.WriteLine($"Greater than 200");
            }
        }
    }
}
