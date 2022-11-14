using System;
using System.Collections.Generic;
using System.Linq;
using _04.WildFarm.Animal;
using _04.WildFarm.Animal.Bird;
using _04.WildFarm.Animal.Mammal;
using _04.WildFarm.Animal.Mammal.Feline;
using _04.WildFarm.Food;

namespace _04.WildFarm
{
    public class Program
    {
        static void Main(string[] args)
        {
            Animal.Animal animal = null;
            Food.Food food = null;
            List<Animal.Animal> animals = new List<Animal.Animal>();


            string[] cmdArgs = Console.ReadLine().Split();

            while (cmdArgs[0] != "End")
            {
                string type = cmdArgs[0];
                cmdArgs = cmdArgs.Skip(1).ToArray();

                switch (type)
                {
                    case "Owl":
                        animal = new Owl(cmdArgs[0], double.Parse(cmdArgs[1]), double.Parse(cmdArgs[2]));
                        break;
                    case "Hen":
                        animal = new Hen(cmdArgs[0], double.Parse(cmdArgs[1]), double.Parse(cmdArgs[2]));
                        break;
                    case "Mouse":
                        animal = new Mouse(cmdArgs[0], double.Parse(cmdArgs[1]), cmdArgs[2]);
                        break;
                    case "Dog":
                        animal = new Dog(cmdArgs[0], double.Parse(cmdArgs[1]), cmdArgs[2]);
                        break;
                    case "Cat":
                        animal = new Cat(cmdArgs[0], double.Parse(cmdArgs[1]), cmdArgs[2], cmdArgs[3]);
                        break;
                    case "Tiger":
                        animal = new Tiger(cmdArgs[0], double.Parse(cmdArgs[1]), cmdArgs[2], cmdArgs[3]);
                        break;
                }

                cmdArgs = Console.ReadLine().Split();
                type = cmdArgs[0];
                cmdArgs = cmdArgs.Skip(1).ToArray();

                int quantity = int.Parse(cmdArgs[0]);
                switch (type)
                {
                    case "Vegetable":
                        food = new Vegetable(quantity);
                        break;
                    case "Fruit":
                        food = new Fruit(quantity);
                        break;
                    case "Meat":
                        food = new Meat(quantity);
                        break;
                    case "Seeds":
                        food = new Seeds(quantity);
                        break;
                }

                Console.WriteLine(animal.ProduceSound());
                animal.Feed(food);
                animals.Add(animal);

                cmdArgs = Console.ReadLine().Split();
            }

            foreach (var ani in animals)
            {
                Console.WriteLine(ani);
            }
        }

    }

}
