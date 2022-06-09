using System;

namespace _03_Gaymin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            string commandargs = Console.ReadLine();
            double gamePrice = 0;
            double moneyGiven = 0;

            while (commandargs != "Game Time")
            {
                if (money == 0.00)
                {
                    Console.WriteLine("Out of money!");
                }
                gamePrice = commandargs == "OutFall 4" ? 39.99 :
                    commandargs == "CG : OG" ? 15.99 :
                    commandargs == "Zplinter Zell" ? 19.99 :
                    commandargs == "Honored 2" ? 59.99 :
                    commandargs == "RoverWatch" ? 29.99 :
                    commandargs == "RoverWatch Origins Edition" ? 39.99 : 1;

                if (gamePrice == 1)
                {
                    Console.WriteLine("Not Found");
                }
                else if (gamePrice > money)
                {
                    Console.WriteLine("Too Expensive");
                }
                else
                {
                    Console.WriteLine($"Bought {commandargs}");
                    moneyGiven += gamePrice;
                    money -= gamePrice;
                }
                gamePrice = 0;
                commandargs = Console.ReadLine();
            }
            if (money == 0.00)
            {
                Console.WriteLine("Out of money!");
            }
            else
            {
                Console.WriteLine($"Total spent: ${moneyGiven:F2}. Remaining: ${money:F2}");
            }
        }

    }
}
