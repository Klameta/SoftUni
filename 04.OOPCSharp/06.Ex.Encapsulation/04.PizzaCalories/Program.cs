
using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.PizzaCalories
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<string> cmdArgs = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                List<Dough> doughList = new List<Dough>();
                List<Topping> toppingList = new List<Topping>();

                while (cmdArgs[0] != "END")
                {
                    string type = cmdArgs[0];
                    cmdArgs = cmdArgs.Skip(1).ToList();

                    switch (type)
                    {
                        case "Dough":
                            string flour = cmdArgs[0];
                            string bakingTechnique = cmdArgs[1];
                            double grams = double.Parse(cmdArgs[2]);

                            Dough dough = new Dough(flour, bakingTechnique, grams);
                            break;
                        case "Topping":
                            string toppingType = cmdArgs[0];
                            grams = double.Parse(cmdArgs[1]);

                            Topping topping = new Topping(toppingType, grams);

                            break;
                    }

                    cmdArgs = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                }

            }
            catch (Exception ex)
            {
                foreach (var topping in toppingList)
                {

                }
            }
        }
    }
}
