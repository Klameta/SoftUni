using System;

namespace _01.GenericBoxOfString
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            for (int i = 0; i < lines; i++)
            {
                Box<int> box = new Box<int>(int.Parse(Console.ReadLine()));
                Console.WriteLine(box);
            }
        }
    }
}
