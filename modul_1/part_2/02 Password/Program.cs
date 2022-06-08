using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_Password
{
    class Program
    {
        static void Main(string[] args)
        {
            var un = Console.ReadLine();
            var pass = Console.ReadLine();

            var passAttempt = Console.ReadLine();
            while (pass !=passAttempt)
            {
                passAttempt = Console.ReadLine();
            }
            Console.WriteLine($"Welcome {un}!");
        }
    }
}
