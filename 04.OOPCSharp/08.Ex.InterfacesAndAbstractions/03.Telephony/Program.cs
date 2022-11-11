using System;
using System.Collections.Generic;

namespace _03.Telephony
{
    public class Program
    {
        static void Main(string[] args)
        {
            Smartphone smartphone = new Smartphone();
            Stationaryphone stationaryphone = new Stationaryphone();
            
            string[] numbers = Console.ReadLine().Split();
            string[] sites = Console.ReadLine().Split();

            foreach (var number in numbers)
            {
                if (number.Length == 7) Console.WriteLine(stationaryphone.Call(number));
                else Console.WriteLine(smartphone.Call(number));
            }

            foreach (string site in sites)
            {
                Console.WriteLine(smartphone.Browse(site));
            }
        }
    }
}
