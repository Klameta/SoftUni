using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
namespace _02._Race
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @"(?<name>[A-Za-z])|(?<km>\d)";
            Dictionary<string, int> competetors = new Dictionary<string, int>();
            string[] participents = Console.ReadLine().Split(", ");
            foreach (var participent in participents)
            {
                competetors.Add(participent, 0);
            }
            string gibberish = Console.ReadLine();


            while (gibberish!="end of race")
            {
                MatchCollection racer = Regex.Matches(gibberish, regex);
                string name = "";
                int km = 0;
                foreach (Match match in racer)
                {
                    foreach (var letter in match.Groups["name"].Value)
                    {
                        name += letter;
                    }
                    foreach (var digit in match.Groups["km"].Value)
                    {
                        km += int.Parse(digit.ToString());
                    }
                }
                if (competetors.ContainsKey(name))
                {
                    competetors[name] += km;
                }
                gibberish = Console.ReadLine();
            }
            int place = 1;
            string letterPlacing = string.Empty;
            foreach (var compt in competetors.OrderByDescending(x=>x.Value).Take(3))
            {
                if (place == 1)
                {
                    letterPlacing = "st";
                }
                else if (place==2)
                {
                    letterPlacing = "nd";
                }
                else
                {
                    letterPlacing = "rd";
                }
                Console.WriteLine($"{place}{letterPlacing} place: {compt.Key}");
                place++;
            }

        }
    }
}
