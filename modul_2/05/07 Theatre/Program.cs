using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Theatre
{
    class Program
    {
        static void Main(string[] args)
        {
            var typeDay = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());
            int prce = 0;
            switch (typeDay)
            {
                case "Weekday":
                    if (age >= 0 && age <= 18)
                    {
                        prce = 12;
                    }
                    else if (age >= 0 && age <= 64)
                    {
                        prce = 18;
                    }
                    else if (age >= 0 && age <= 122)
                    {
                        prce = 12;
                    }
                    else
                    {
                        Console.WriteLine("Error!");
                    }
                    break;
                case "Weekend":
                    if (age >= 0 && age <= 18)
                    {
                        prce = 15;
                    }
                    else if (age >= 0 && age <= 64)
                    {
                        prce = 20;
                    }
                    else if (age >= 0 && age <= 122)
                    {
                        prce = 15;
                    }
                    else
                    {
                        Console.WriteLine("Error!");
                    }
                    break;
                case "Holiday":
                    if (age >= 0 && age <= 18)
                    {
                        prce = 5;
                    }
                    else if (age >= 0 && age <= 64)
                    {
                        prce = 12;
                    }
                    else if (age >= 0 && age <= 122)
                    {
                        prce = 10;
                    }
                    else
                    {
                        Console.WriteLine("Error!");
                    }
                    break;

            }
            if (prce > 0)
            {
                Console.WriteLine($"{prce}$");

            }

        }
    }
}
