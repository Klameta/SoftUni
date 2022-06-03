using System;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            int g = int.Parse(Console.ReadLine());
            string time = Console.ReadLine();

            var outfit = "";
            var shoes = "";

            if (g<=18)
            {
                if (time =="Morning")
                {
                    outfit = "Sweatshirt";
                    shoes = "Sneakers";
                }
                else if (time =="Afternoon")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
            }
            else if (g<=24)
            {
                if (time == "Morning")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (time == "Afternoon")
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";  
                }
                else
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
            }
            else
            {
                if (time == "Morning")
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
                else if (time == "Afternoon")
                {
                    outfit = "Swim Suit";
                    shoes = "Barefoot";
                }
                else
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
            }
            Console.WriteLine($"It's {g} degrees, get your { outfit} and { shoes}.");

        }
    }
}
