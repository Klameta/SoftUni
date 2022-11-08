
using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.PizzaCalories
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> cmdArgs = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            try
            {
                string name = cmdArgs[1];
                Pizza pizza = new Pizza(name);

                cmdArgs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
                string flour = cmdArgs[1];
                string bakingTechnique = cmdArgs[2];
                double grams = double.Parse(cmdArgs[3]);
                Dough dough = new Dough(flour, bakingTechnique, grams);

                pizza.Dough = dough;
                List<Topping> toppingList = new List<Topping>();

                cmdArgs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
                while (cmdArgs[0] != "END")
                {
                    string type = cmdArgs[0];
                    cmdArgs = cmdArgs.Skip(1).ToList();

                    switch (type)
                    {
                        
                        case "Topping":
                            string toppingType = cmdArgs[0];
                            grams = double.Parse(cmdArgs[1]);

                            Topping topping = new Topping(toppingType, grams);
                            pizza.AddToppings(topping);
                            break;
                    }

                    cmdArgs = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                }

                int count = pizza.ToppingCount;
                Console.WriteLine(pizza);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
