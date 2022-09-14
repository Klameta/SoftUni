using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace _01._Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @"[>]{2}(?<name>[A-Za-z\s]+)[<]{2}(?<price>\d+(.\d+)?)!(?<quantity>\d+)";
            string items = Console.ReadLine();
            List<string> namesOfFurnitures = new List<string>();
            double sum = 0;
            while (items != "Purchase")
            {
                Match match = Regex.Match(items, regex);
                if (match.Success)
                {

                    string name = match.Groups["name"].Value;
                    double price = double.Parse(match.Groups["price"].Value);
                    double quantity = double.Parse(match.Groups["quantity"].Value);
                    sum += price * quantity;
                    namesOfFurnitures.Add(name);
                }
                items = Console.ReadLine();
            }
            Console.WriteLine("Bought furniture:");
            foreach (var furni in namesOfFurnitures)
            {
                Console.WriteLine(furni);
            }
            Console.WriteLine($"Total money spend: {sum:F2}");
        }
    }
}
