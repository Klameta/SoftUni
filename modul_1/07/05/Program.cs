using System;

namespace _05
{
    class Program
    {
        static void Main(string[] args)
        {

            string item = Console.ReadLine().ToLower();
            string city = Console.ReadLine().ToLower();
            double prc = double.Parse(Console.ReadLine());
            if (city == "sofia")
            {
                if (item == "coffee")
                    prc *= 0.50;
                else if (item == "water")
                    prc *= 0.80;
                else if (item == "beer")
                    prc *= 1.20;
                else if (item == "sweets")
                    prc *= 1.45;
                else if (item == "peanuts")
                    prc *= 1.60;
            }

            if (city == "plovdiv")
            {
                if (item == "coffee")
                    prc *= 0.40;
                else if (item == "water")
                    prc *= 0.70;
                else if (item == "beer")
                    prc *= 1.15;
                else if (item == "sweets")
                    prc *= 1.30;
                else if (item == "peanuts")
                    prc *= 1.50;
            }

            if (city == "varna")
            {
                if (item == "coffee")
                    prc *= 0.45;
                else if (item == "water")
                    prc *= 0.70;
                else if (item == "beer")
                    prc *= 1.10;
                else if (item == "sweets")
                    prc *= 1.35;
                else if (item == "peanuts")
                    prc *= 1.55;
            }
            Console.WriteLine(prc.ToString());
        }
    }
}
