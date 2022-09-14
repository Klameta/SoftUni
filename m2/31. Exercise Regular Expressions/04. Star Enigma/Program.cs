using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;
namespace _04._Star_Enigma
{
    class Program
    {
        static void Main(string[] args)
        {
            string decryting = @"[starSTAR]";
            string finalDecode = @"@(?<planetName>[A-Za-z]+)[^@_!:>]*[:](?<population>[\d]+)[^@_!:>]*!(?<attackType>\w)![^@_!:>]*->(?<solderCount>\d+)";
            int lines = int.Parse(Console.ReadLine());
            StringBuilder clean = new StringBuilder();
            List<string> attacked = new List<string>();
            List<string> destroyed = new List<string>();
            for (int i = 0; i < lines; i++)
            {
                string decrypted = Console.ReadLine();
                MatchCollection stars = Regex.Matches(decrypted, decryting);
                int key = stars.Count();
                char[] dec = decrypted.ToCharArray();
                for (int k = 0; k < decrypted.Length; k++)
                {
                    dec[k] -= (char)key;
                }
                string decoded = new string(dec);
                MatchCollection workingLine = Regex.Matches(decoded, finalDecode);
                foreach (Match linr in workingLine)
                {
                    string attackType = linr.Groups["attackType"].Value;
                    string planetName = linr.Groups["planetName"].Value;
                    if (attackType == "A")
                    {
                        attacked.Add(planetName);
                    }
                    else
                    {
                        destroyed.Add(planetName);
                    }
                }


            }
            attacked.Sort();
            destroyed.Sort();
            Console.WriteLine($"Attacked planets: {attacked.Count}");
            foreach (var att in attacked)
            {
                Console.WriteLine($"-> {att}");
            }
            Console.WriteLine($"Destroyed planets: {destroyed.Count}");
            foreach (var des in destroyed)
            {
                Console.WriteLine($"-> {des}");
            }
        }
    }
}
