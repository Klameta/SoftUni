using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;

namespace _07.TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            int petrolPumps = int.Parse(Console.ReadLine());
            long totalDistance = 0;
            Stack<long> stations = new Stack<long>();
                
            for (int i = 0; i < petrolPumps; i++)
            {
                long[] pumpInfo = Console.ReadLine().Split().Select(long.Parse).ToArray();
                long petrol = pumpInfo[0];
                long distance = pumpInfo[1];

                stations.Push(petrol);
                totalDistance += distance + 1;
            }
            int index = 0;

            while (totalDistance>0)
            {
                totalDistance -= stations.Pop();
                index++;
            }
            Console.WriteLine(index);
        }
    }
}
