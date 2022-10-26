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
            Box<double> boxes = new Box<double>();

            for (int i = 0; i < lines; i++)
            {
                boxes.Items.Add(double.Parse(Console.ReadLine()));
            }
            double compere = double.Parse(Console.ReadLine());

            Console.WriteLine(boxes.CompareCount(compere));
        }

        
    }
}
