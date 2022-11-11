using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.BirthdayCelebrations
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<IBirthable> humanoids = new List<IBirthable>();
            string[] cmdArgs = Console.ReadLine().Split();

            while (cmdArgs[0]!= "End")
            {
                string type = cmdArgs[0];
                cmdArgs = cmdArgs.Skip(1).ToArray();

                switch (type)
                {
                    case "Citizen":
                        string name = cmdArgs[0];
                        int age = int.Parse(cmdArgs[1]);
                        string id = cmdArgs[2];
                        string birtdate = cmdArgs[3];

                        Citizen citizen = new Citizen(name, age, id, birtdate);
                        humanoids.Add(citizen);
                        break;
                    case "Robot":
                        name = cmdArgs[0];
                        id = cmdArgs[1];

                        Robot robot = new Robot(name,id);
                        //humanoids.Add(robot);
                        break;
                    case "Pet":
                        name = cmdArgs[0];
                        birtdate = cmdArgs[1];

                        Pet pet = new Pet(name, birtdate);

                        humanoids.Add(pet);
                        break;
                }
                cmdArgs = Console.ReadLine().Split();
            }

            string year = Console.ReadLine();
            humanoids = humanoids.Where(x => x.Birthdate.EndsWith(year)).ToList();

            Console.WriteLine(string.Join(Environment.NewLine, humanoids));
        }
    }
}
