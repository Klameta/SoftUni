using System;
using System.Collections.Generic;

namespace _03.Telephony
{
    public class Program
    {
        static void Main(string[] args)
        {
            Smartphone smartphone = new Smartphone();
            
            string[] numbers = Console.ReadLine().Split(' ');
            string[] sites = Console.ReadLine().Split(' ');

            foreach (var number in numbers)
            {
                Console.WriteLine(smartphone.Calling(number));
            }

            foreach (string site in sites)
            {
                Console.WriteLine(smartphone.Browse(site));
            }
        }
    }
}
