using System;
using System.Linq;
namespace _01_Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int numLines = int.Parse(Console.ReadLine());
            int[] passengers = new int[numLines];
            int sum = 0;

            for (int i = 0; i < numLines; i++)
            {
                passengers[i] = int.Parse(Console.ReadLine());
                sum+=passengers[i];
            }

            Console.WriteLine(string.Join(" ", passengers));
            Console.WriteLine(sum);
        }
    }
}
