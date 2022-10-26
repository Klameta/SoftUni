using System;

namespace _10.ThePartyReservationFilterModule
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string[] cmdArgs = Console.ReadLine()
                .Split(';', StringSplitOptions.RemoveEmptyEntries);

            while (cmdArgs[0]!= "Print")
            {



                cmdArgs = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);
            }
        }
    }
}
