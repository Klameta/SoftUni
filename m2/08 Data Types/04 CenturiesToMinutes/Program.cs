using System;

namespace _04_CenturiesToMinutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cent = short.Parse(Console.ReadLine());
            int years = cent * 100;
            long days = (long)(years * 365.2422);
            long hours = days * 24;
            long minutes = hours * 60;

            Console.WriteLine($"{cent} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");
        }
    }
}
