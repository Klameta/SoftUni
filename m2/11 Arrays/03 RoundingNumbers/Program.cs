using System;
using System.Linq;
namespace _03_RoundingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();

            foreach (var number in numbers)
            {
                int modNum = (int)Math.Round(number, MidpointRounding.AwayFromZero);

                Console.WriteLine($"{number} => {modNum}");
            }
        }
    }
}
