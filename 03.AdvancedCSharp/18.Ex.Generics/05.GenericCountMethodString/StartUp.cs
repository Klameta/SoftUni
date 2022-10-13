using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.GenericCountMethodString
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            Box<string> boxes = new Box<string>();

            for (int i = 0; i < lines; i++)
            {
                boxes.Items.Add(Console.ReadLine());
            }
            string compere = Console.ReadLine();

            Console.WriteLine(boxes.CompareCount(compere));
        }

        
    }
}
