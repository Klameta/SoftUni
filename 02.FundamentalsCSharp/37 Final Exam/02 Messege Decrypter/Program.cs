using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02_Messege_Decrypter
{
    class Program
    {
        static void Main(string[] args)
        {
            string messegeDecryptor = @"\A(?<seperator>[$%]{1})(?<tag>[A-Z]{1}[a-z]{2,})\k<seperator>: \[(?<num1>[0-9]+)\]\|\[(?<num2>[0-9]+)\]\|\[(?<num3>[0-9]+)\]\|$";
            int lines = int.Parse(Console.ReadLine());
            for (int i = 0; i < lines; i++)
            {
                string message = Console.ReadLine();
                string result = string.Empty;
                Match match = Regex.Match(message, messegeDecryptor);
                if (match.Success)
                {
                    char first = (char)(int.Parse(match.Groups["num1"].Value.ToString()));
                    char second = (char)(int.Parse(match.Groups["num2"].Value.ToString()));
                    char third = (char)(int.Parse(match.Groups["num3"].Value.ToString()));
                    Console.WriteLine($"{match.Groups["tag"].Value}: {first}{second}{third}");
                }
               is and not
                else
                {
                    Console.WriteLine("Valid message not found!");
                }
            }
        }
    }
}
