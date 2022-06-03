using System;

namespace _01_06_01._09._2022
{
    class Program
    {
        static void Main(string[] args)
        {
            string Fname = Console.ReadLine();
            string Lname = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string town = Console.ReadLine();
            Console.WriteLine($"You are {Fname} {Lname}, a {age}-years old person from {town}.");
        }
    }
}
