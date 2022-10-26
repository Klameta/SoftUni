using System;

namespace CustomRandomList
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            RandomList strings = new RandomList();
            strings.Add("sad");
            strings.Add("hyhf");
            strings.Add("sgf");
            Console.WriteLine(strings.RandomString());
        }
    }
}
