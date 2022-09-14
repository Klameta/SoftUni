using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Ages
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());

            if (age <= 2)
            {
                Console.WriteLine("baby");
            }
            else if (age > 2 && age <= 13)
            {
                Console.WriteLine("child");
            }
            else if (age > 13 && age <= 19)
            {
                Console.WriteLine("teenager");
            }
            else if (age > 19 && age <= 65)
            {
                Console.WriteLine("adult");
            }
            else if (age > 65 && age >= 66)
            {
                Console.WriteLine("elder");
            }
        }
    }
}
