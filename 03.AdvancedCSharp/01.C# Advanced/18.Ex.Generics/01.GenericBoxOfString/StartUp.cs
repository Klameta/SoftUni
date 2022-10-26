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
                Box<string> box = new Box<string>(Console.ReadLine());
                Console.WriteLine(box);
            }
        }
    }
}
