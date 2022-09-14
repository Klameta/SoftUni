using System;

namespace _09_SpiceFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            int startYield = int.Parse(Console.ReadLine());
            int yieldSum = 0;
            int dayCounter = 0;

            while (startYield >= 100)
            {
                yieldSum += startYield;
                startYield -= 10;
                dayCounter++;

                if (yieldSum - 26 > 0)
                {
                    yieldSum -= 26;
                }
            }

            if (yieldSum - 26 > 0)
            {
                yieldSum -= 26;
            }
            Console.WriteLine(dayCounter);
            Console.WriteLine(yieldSum);
        }
    }
}
