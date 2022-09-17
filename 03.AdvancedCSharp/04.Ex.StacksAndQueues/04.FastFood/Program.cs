using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
namespace _04.FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantity = int.Parse(Console.ReadLine());
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> orders = new Queue<int>();

            Console.WriteLine(nums.Max());

            foreach (var num in nums)
            {
                orders.Enqueue(num);
            }

            while (orders.Count > 0)
            {
                if (quantity - orders.Peek() > 0)
                {

                int currentOrder = orders.Peek();
                quantity -= currentOrder;
                orders.Dequeue();
                }
            }

            if (orders.Count > 0)
            {
                Console.WriteLine($"Orders left: {string.Join(", ", orders)}");
            }
            else
            {
                Console.WriteLine("Orders complete");
            }
        }
    }
}
