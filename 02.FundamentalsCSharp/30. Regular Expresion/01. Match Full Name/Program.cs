using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;
namespace _01._Match_Full_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @"\b([A-Z]{1}[a-z]+) ([A-Z]{1}[a-z]+)";
            string names = Console.ReadLine();
            MatchCollection matchedNames = Regex.Matches(names, regex);

            foreach (Match name in matchedNames)
            {
                Console.Write(name.Value + " ");
            }
            Console.WriteLine();
        }
    }
}
