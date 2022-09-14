using System;
using System.Linq;
using System.Collections.Generic;
namespace _01._Cooking_Masterclass
{
    class Program
    {
        static void Main(string[] args)
        {
            int eggCount = 10;
            double budget = double.Parse(Console.ReadLine());
            int studentCount = int.Parse(Console.ReadLine());
            double flourPrice = double.Parse(Console.ReadLine());
            double eggPrice = double.Parse(Console.ReadLine());
            double apronPrice = double.Parse(Console.ReadLine());

            double result = apronPrice * (Math.Ceiling(studentCount + studentCount * 0.2)) + eggPrice * 10 * studentCount + flourPrice * (studentCount - (int)studentCount / 5);
            if (budget<result)
            {
                Console.WriteLine($"{result-budget:F2}$ more needed.");
            }
            else
            {
                Console.WriteLine($"Items purchased for {result:F2}$.");
            }
        }
    }
}
