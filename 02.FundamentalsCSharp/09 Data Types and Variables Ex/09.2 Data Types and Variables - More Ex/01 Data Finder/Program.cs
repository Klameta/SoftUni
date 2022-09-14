using System;

namespace _01_Data_Finder
{
    class Program
    {
        static void Main(string[] args)
        {
            string commandArgs = Console.ReadLine();
            while (commandArgs != "END")
            {
                if (int.TryParse(commandArgs, out int i))//int
                {
                    Console.WriteLine($"{commandArgs} is integer type");
                }
                else if (char.TryParse(commandArgs, out char j))//char
                {
                    Console.WriteLine($"{commandArgs} is character type");
                }
                else if (bool.TryParse(commandArgs, out bool b))//bool
                {
                    Console.WriteLine($"{commandArgs} is boolean type");
                }
                else if (double.TryParse(commandArgs, out double k))//float
                {
                    Console.WriteLine($"{commandArgs} is floating point type");
                }
                else//str
                {
                    Console.WriteLine($"{commandArgs} is string type");
                }
                commandArgs = Console.ReadLine();
            }
        }
    }
}
