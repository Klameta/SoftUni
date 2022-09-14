using System;
namespace _07_Vendig
{
    class Program
    {
        static void Main(string[] args)
        {
            var commandargs = Console.ReadLine();
            double num = 0;
            double money = 0;
            var s = true;
            while (commandargs != "End")
            {
                while (s)
                {
                    if (commandargs == "Start")
                    {
                        s = false;
                        break;
                    }

                    if (double.TryParse(commandargs, out num))
                    {



                        switch (num)
                        {
                            case 0.1:
                            case 0.2:
                            case 0.5:
                            case 1:
                            case 2:
                                money += num;
                                break;
                            default:
                                Console.WriteLine($"Cannot accept {num}");
                                break;
                        }
                    }
                    commandargs = Console.ReadLine();
                }
                double price = commandargs == "Nuts"
                    ? 2.0 : commandargs == "Water"
                    ? 0.7 : commandargs == "Crisps"
                    ? 1.5 : commandargs == "Soda"
                    ? 0.8 : commandargs == "Coke"
                    ? 1.0 : 0.0;

                if (price == 0.0 && commandargs!= "Start")
                {
                    Console.WriteLine("Invalid product");
                    commandargs = Console.ReadLine();

                }
                else
                {

                    if (commandargs != "Start")
                    {
                        if (money >= price)
                        {
                            Console.WriteLine($"Purchased {commandargs.ToLower()}");
                            money -= price;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                    }

                    commandargs = Console.ReadLine();
                }
            }
            Console.WriteLine($"Change: {money:F2}");
        }
    }
}
