using System;
using System.Linq;

namespace _07.Tuple
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] nameAdress = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Tuple<string, string> first = new Tuple<string, string>
                (string.Join(" ", nameAdress.Take(2)), nameAdress[2]);

            string[] nameBeers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Tuple<string, int> nameBeersTuple = new Tuple<string, int>
                (nameBeers[0], int.Parse(nameBeers[1]));

            double[] nums = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();
            Tuple<int, double> numsTuple = new Tuple<int, double>((int)nums[0], nums[1]);

            Console.WriteLine($"{first}\n" +
                $"{nameBeersTuple}\n" +
                $"{numsTuple}");


        }
    }
}
