using System;

namespace _11_Math_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            string @operator = Console.ReadLine();
            int second = int.Parse(Console.ReadLine());
            Console.WriteLine(Operation(first,second,@operator));
        }
        static double Operation(int first, int second, string @operator)
        {
            if (@operator == @"/")
            {
                return (double)first / second;
            }
            else if (@operator == @"*")
            {
                return first * second;

            }
            else if (@operator == @"+")
            {
                return first + second;

            }
            else
            {
                return first - second;
            }
        }
    }
}
