using System;
using System.Collections.Generic;
using System.Linq;
namespace _02._07.ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> carNumbers = new HashSet<string>();
            string[] cmdArgs = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            while (cmdArgs[0]!="END")
            {
                switch (cmdArgs[0])
                {
                    case "IN":
                        carNumbers.Add(cmdArgs[1]);
                        break;
                    case "OUT":
                        carNumbers.Remove(cmdArgs[1]);
                        break;
                }
                cmdArgs = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            }

            if (carNumbers.Count()!= 0)
            {
                Console.WriteLine(string.Join("\n", carNumbers));
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
