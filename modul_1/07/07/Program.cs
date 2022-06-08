using System;

namespace _07
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            string dWeek = Console.ReadLine();
            if (dWeek!= "Sunday")
            {
                if (hours >=10 && hours <=18)
                {
                    Console.WriteLine("open");
                }
                else
                {
                    Console.WriteLine("closed");
                }
            }
            else
            {
                Console.WriteLine("closed");
            }

        }
    }
}
