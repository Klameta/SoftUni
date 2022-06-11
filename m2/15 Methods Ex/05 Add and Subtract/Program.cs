using System;

namespace _05_Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            Console.WriteLine(Division(first,second,third));
        }
        static int Addition(int first, int second)
        {
            return first + second;
        }
        static int Division(int first, int second,int third)
        {
            int add = Addition(first, second);
            return add - third;
        }
    }
}
