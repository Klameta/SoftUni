using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace _03._Match_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @"\b(?<day>[0-9]{2})(?<seperator>[./-])(?<month>[A-z]{1}[a-z]{2})\k<seperator>(?<year>[0-9]{4})";
            string dates = Console.ReadLine();
            MatchCollection validDates = Regex.Matches(dates, regex);

            foreach (Match date in validDates)
            {
                string day = date.Groups["day"].Value;
                string month =  date.Groups["month"].Value;
                string year = date.Groups["year"].Value;
                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
