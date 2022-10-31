using System;
using System.Collections.Generic;
namespace Animals
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string[] cmdArgs = Console.ReadLine().Split();
            List<Animal> animals = new List<Animal>();

            while (cmdArgs[0] != "Beast!")
            {
                string type = cmdArgs[0];

                cmdArgs = Console.ReadLine().Split();

                string name = cmdArgs[0];
                int age = int.Parse(cmdArgs[1]);
                string gender = cmdArgs[2];

                Animal animal = null;
                try
                {

                    switch (type)
                    {
                        case "Cat":
                            animal = new Cat(name, age, gender);
                            break;
                        case "Kitten":
                            animal = new Kitten(name, age, gender);
                            break;
                        case "Tomcat":
                            animal = new Tomcat(name, age, gender);
                            break;
                        case "Dog":
                            animal = new Dog(name, age, gender);
                            break;
                        case "Frog":
                            animal = new Frog(name, age, gender);
                            break;
                    }
                    animals.Add(animal);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                cmdArgs = Console.ReadLine().Split();
            }
            foreach (var animal in animals)
            {
                Console.WriteLine(animal.ToString());
            }
        }
    }
}
