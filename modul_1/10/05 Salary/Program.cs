using System;

namespace _05_Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int nTabs = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());

            int fb = 0;
            int inst = 0;
            int redd = 0;

            for (int i = 0; i < nTabs; i++)
                
            {
                string tab = Console.ReadLine();
                switch (tab)
                {
                    case "Facebook":
                        salary -= 150;
                        break;
                    case "Instagram":
                        salary -= 100;
                        break;
                    case "Reddit":
                        salary -= 50;
                        break;
                }
                if (salary<=0)
                {
                    Console.WriteLine($"You have lost your salary.");
                    break;

                }
            }

            if (salary>0)
            {
                Console.WriteLine($"{salary}");

            }
        }
    }
}
