using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.BorderControl
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<IIndetifiable> humanoids = new List<IIndetifiable>();
            string[] cmdArgs = Console.ReadLine().Split();

            while (cmdArgs[0]!= "End")
            {
                if (cmdArgs.Length ==3)
                {
                    Citizen citizen = new Citizen(cmdArgs[0], int.Parse(cmdArgs[1]), cmdArgs[2]);
                    humanoids.Add(citizen);
                }
                else
                {
                    Robot robot = new Robot(cmdArgs[0], cmdArgs[1]);
                    humanoids.Add(robot);
                }

                cmdArgs = Console.ReadLine().Split();
            }

            string imposter = Console.ReadLine();
            humanoids = humanoids.Where(x => x.Id.EndsWith(imposter)).ToList();

            Console.WriteLine(string.Join(Environment.NewLine, humanoids));
        }
    }
}
