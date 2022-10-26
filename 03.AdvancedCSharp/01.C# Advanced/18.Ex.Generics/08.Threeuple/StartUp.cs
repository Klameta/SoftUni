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
            Threeuple<string, string, string> first = new Threeuple<string, string, string>
                (string.Join(" ", nameAdress.Take(2)), nameAdress[2], nameAdress[3]);

            string[] nameBeers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            bool drunk = nameBeers[2] == "drunk";

            Threeuple<string, int, bool> nameBeersTuple = new Threeuple<string, int, bool>
                (nameBeers[0], int.Parse(nameBeers[1]), drunk);

            string[] nums = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            Threeuple<string, double, string> numsTuple = new Threeuple<string, double, string>
                (nums[0], double.Parse(nums[1]), nums[2]);

            Console.WriteLine($"{first}\n" +
                $"{nameBeersTuple}\n" +
                $"{numsTuple}");

        }
    }
}
