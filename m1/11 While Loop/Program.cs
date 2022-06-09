using System;
using System.Collections.Generic;
using System.Linq;

namespace _11_While_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            while (name !="Stop")
            {
                Console.WriteLine(name);
                name= Console.ReadLine();
            }
        }
    }
}
