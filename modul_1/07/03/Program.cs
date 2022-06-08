using System;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            string nInput = Console.ReadLine();
            switch (nInput)
            {
                case "dog":
                    Console.WriteLine("mammal");
                    break;
                case "crocodile":
                case "tortoise":
                case "snake":
                    Console.WriteLine("reptile");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }

        }
    }
}
