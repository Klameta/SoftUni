using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Login
{
    class Program
    {
        static void Main(string[] args)
        {
            var com = Console.ReadLine();
            var comtry = Console.ReadLine();
            var com2 = "";
            var count = 1;
            for (int i = com.Length - 1; i >= 0; i--)
            {
                com2 += com[i];
            }

            while (comtry != com2)
            {
                Console.WriteLine("Incorrect password. Try again.");
                comtry = Console.ReadLine();
                if (count > 2)
                {
                    Console.WriteLine($"User {com} blocked!");
                    break;
                }
                count++;

            }

            if (comtry == com2)
            {
                Console.WriteLine($"User {com} logged in.");
            }
        }
    }
}
