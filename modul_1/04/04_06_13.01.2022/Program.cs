using System;

namespace _04_06_13._01._2022
{
    class Program
    {
        static void Main(string[] args)
        {
            double nInput = double.Parse(Console.ReadLine());
            if (nInput <= 10)
            {
                Console.WriteLine($"slow");
            }
            else if (nInput<=50)
            {
                Console.WriteLine($"average");
            }
            else if (nInput<=150)
            {
                Console.WriteLine($"fast");

            }
            else if (nInput<=1000)
            {
                Console.WriteLine($"ultra fast");
            }
            else
            {
                Console.WriteLine($"extremely fast");
            }
        }
    }
}
