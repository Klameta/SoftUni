using System;
using System.Collections.Generic;

namespace _06.FoodShortage
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, IBuyer> hungries = new Dictionary<string, IBuyer>();
            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                string[] hugriesInfo = Console.ReadLine().Split();
                IBuyer person = null;

                if (hugriesInfo.Length == 4)
                {
                    person = new Citizen(hugriesInfo[0], int.Parse(hugriesInfo[1]), hugriesInfo[2], hugriesInfo[3]);
                }
                else
                {
                    person = new Rebel(hugriesInfo[0], int.Parse(hugriesInfo[1]), hugriesInfo[2]);
                }

                if (!hungries.ContainsKey(hugriesInfo[0]))
                {
                    hungries.Add(hugriesInfo[0], person);
                }
            }



            string[] cmdArgs = Console.ReadLine().Split();
            int sum = 0;
            while (cmdArgs[0]!="End")
            {
                string name = cmdArgs[0];
                if (hungries.ContainsKey(name))
                {
                    sum += hungries[name].BuyFood();
                }

                cmdArgs = Console.ReadLine().Split();
            }

            Console.WriteLine(sum);
        }
    }
}
