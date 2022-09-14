using System;
using System.Collections.Generic;

namespace _01_DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] days =
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            int day = int.Parse(Console.ReadLine());
            if (day > 0 && day < 8)
            {
                string result = days[day - 1];
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}
