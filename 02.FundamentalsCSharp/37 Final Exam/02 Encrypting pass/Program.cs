using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _02_Encrypting_pass
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @"(?<gibberish>.+)>(?<numbers>\d{3})\|(?<lower>[a-z]{3})\|(?<upper>[A-Z]{3})\|(?<not>[^<>]{3})<\k<gibberish>$";
            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                string passtry = Console.ReadLine();
                string result = string.Empty;
                Match match = Regex.Match(passtry, regex);
                if (match.Success)
                {
                    result += match.Groups["numbers"].Value;
                    result += match.Groups["lower"].Value;
                    result += match.Groups["upper"].Value;
                    result += match.Groups["not"].Value;
                    Console.WriteLine($"Password: {result}");
                }
                else
                {
                    Console.WriteLine("Try another password!");
                }
            }
        }
    }
}
