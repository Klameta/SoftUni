using System;
using System.Linq;
using System.Collections.Generic;
namespace _06.Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            string cmdArgs = Console.ReadLine();
            Queue<string> names = new Queue<string>();
            while (cmdArgs!="End")
            {
                switch (cmdArgs)
                {
                    case "Paid":
                        while (names.Count!=0)
                        {
                            Console.WriteLine(names.Dequeue());
                        }
                        break;
                    default:
                        names.Enqueue(cmdArgs);
                        break;
                }

                cmdArgs = Console.ReadLine();
            }
            Console.WriteLine($"{names.Count} people remaining.");
        }
    }
}
