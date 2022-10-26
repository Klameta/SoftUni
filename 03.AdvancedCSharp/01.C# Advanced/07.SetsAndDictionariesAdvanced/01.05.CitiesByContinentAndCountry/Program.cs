using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._05.CitiesByContinentAndCountry
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, List<string>>> continets = new Dictionary<string, Dictionary<string, List<string>>>();
            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                string[] cmdArgs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string continent = cmdArgs[0];
                string country = cmdArgs[1];
                string city = cmdArgs[2];

                if (!continets.ContainsKey(continent))
                {
                    continets.Add(continent, new Dictionary<string,List<string>>());
                    FillinfTheDict(continets, continent, country, city);

                }
                else
                {
                    FillinfTheDict(continets, continent, country, city);
                }
            }

            foreach (var continet in continets)
            {
                Console.WriteLine($"{continet.Key}:");
                foreach (var country in continet.Value)
                {
                    Console.WriteLine($"  {country.Key} -> {string.Join(", ", country.Value)}");
                }
            }
        }

        private static void FillinfTheDict(Dictionary<string, Dictionary<string, List<string>>> continets, string continent, string country, string city)
        {
            if (!continets[continent].ContainsKey(country))
            {
                continets[continent].Add(country, new List<string>());
                continets[continent][country].Add(city);
            }
            else
            {
                continets[continent][country].Add(city);
            }
        }
    }
}
