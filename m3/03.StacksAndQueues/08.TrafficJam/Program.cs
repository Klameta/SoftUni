using System;
using System.Collections.Generic;
using System.Linq;
namespace _08.TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            int nOfCarsThatPass = int.Parse(Console.ReadLine());
            string cmdArgs = Console.ReadLine();
            Queue<string> cars = new Queue<string>();
            int counter = 0;

            while (cmdArgs!="end")
            {
                switch (cmdArgs)
                {
                    case "green":
                        for (int i = 0; i < nOfCarsThatPass; i++)
                        {
                            if (cars.Count != 0)
                            {
                                Console.WriteLine($"{cars.Dequeue()} passed!");
                                counter++;
                            }
                        }
                        break;
                    default:
                        cars.Enqueue(cmdArgs);
                        break;
                }
                cmdArgs = Console.ReadLine();
            }
            Console.WriteLine($"{counter} cars passed the crossroads.");
        }
    }
}
