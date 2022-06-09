using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam._02
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int hoursSpend = int.Parse(Console.ReadLine());
            int peopleInGroud = int.Parse(Console.ReadLine());
            string dOrN = Console.ReadLine();
            double pricePerPerson = 0;
            double ppp = 1;

            switch (dOrN)
            {
                case "day":
                    if (month == "march"|| month == "april" || month == "may")
                    {
                        pricePerPerson = 10.50;
                        if (peopleInGroud >=4)
                        {
                            pricePerPerson = pricePerPerson-(pricePerPerson* 0.10);
                        }
                        if (hoursSpend>=5 )
                        {
                            pricePerPerson = pricePerPerson - (pricePerPerson * 0.50);
                        }
                    }
                    else
                    {
                        pricePerPerson = 12.60;
                        if (peopleInGroud >= 4)
                        {
                            pricePerPerson = pricePerPerson - (pricePerPerson * 0.10);
                        }
                        if (hoursSpend >= 5)
                        {
                            pricePerPerson = pricePerPerson - (pricePerPerson * 0.50);
                        }
                    }
                    break;
                case "night":
                    if (month == "march" || month == "april" || month == "may")
                    {
                        pricePerPerson = 8.40 ;
                        if (peopleInGroud >= 4)
                        {
                            pricePerPerson = pricePerPerson - (pricePerPerson * 0.10);
                        }
                        if (hoursSpend >= 5)
                        {
                            pricePerPerson = pricePerPerson - (pricePerPerson * 0.50);
                        }
                    }
                    else
                    {
                        pricePerPerson = 10.20;
                        if (peopleInGroud >= 4)
                        {
                            pricePerPerson = pricePerPerson - (pricePerPerson * 0.10);
                        }
                        if (hoursSpend >= 5)
                        {
                            pricePerPerson = pricePerPerson - (pricePerPerson * 0.50);
                        }
                    }
                    break;
            }

            Console.WriteLine($"Price per person for one hour: {pricePerPerson:F2}");
            Console.WriteLine($"Total cost of the visit: {pricePerPerson*hoursSpend*peopleInGroud:F2}");

        }
    }
}
