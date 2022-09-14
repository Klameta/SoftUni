using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
namespace _02._Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @"\+359(?<seperator>[ |-])2\k<seperator>(?<middleNums>[0-9]{3}\b)\k<seperator>(?<lastNums>[0-9]{4}\b)";
            string numbers = Console.ReadLine();
            MatchCollection phoneMatches = Regex.Matches(numbers, regex);
            Console.WriteLine(string.Join(", ", phoneMatches));
        }
    }
}
