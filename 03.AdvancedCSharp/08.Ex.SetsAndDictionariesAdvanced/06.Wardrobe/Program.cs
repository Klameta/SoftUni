using System;
using System.Linq;
using System.Collections.Generic;

namespace _06.Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();
            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                string[] color = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                string[] clothes = color.Last().Split(",", StringSplitOptions.RemoveEmptyEntries);

                if (!wardrobe.ContainsKey(color[0]))
                {
                    wardrobe.Add(color[0], new Dictionary<string, int>());
                }
                foreach (var clothing in clothes)
                {
                    if (!wardrobe[color[0]].ContainsKey(clothing))
                    {
                        wardrobe[color[0]].Add(clothing, 1);
                    }
                    else
                    {
                        wardrobe[color[0]][clothing]++;
                    }
                }

            }

            string[] filter = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string found = string.Empty;
            foreach (var color in wardrobe)
            {
                Console.WriteLine($"{color.Key} clothes:");
                foreach (var clothing in color.Value)
                {
                    if (color.Key == filter[0] && clothing.Key == filter[1])
                    {
                        found = " (found!)";
                    }
                    Console.WriteLine($"* {clothing.Key} - {clothing.Value}{found}");
                    found = string.Empty;
                }
            }

        }
    }
}
