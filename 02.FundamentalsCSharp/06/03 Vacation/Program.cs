using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();
            var pricePerPerson = 0.00;
            var totalPrice = 0.00;

            switch (type)
            {
                case "Students":
                    if (day == "Friday")
                    {
                        pricePerPerson = 8.45;
                    }
                    else if (day == "Saturday")
                    {
                        pricePerPerson = 9.80;
                    }
                    else
                    {
                        pricePerPerson = 10.46;
                    }
                    totalPrice = count * pricePerPerson;
                    if (count >= 30)
                    {
                        totalPrice = totalPrice - totalPrice * 0.15;
                    }
                    break;
                case "Business":
                    if (day == "Friday")
                    {
                        pricePerPerson = 10.90;
                    }
                    else if (day == "Saturday")
                    {
                        pricePerPerson = 15.60;
                    }
                    else
                    {
                        pricePerPerson = 16;
                    }

                    if (count >= 100)
                    {
                        count -= 10;
                    }
                    totalPrice = count * pricePerPerson;

                    break;
                case "Regular":
                    if (day == "Friday")
                    {
                        pricePerPerson = 15;
                    }
                    else if (day == "Saturday")
                    {
                        pricePerPerson = 20;
                    }
                    else
                    {
                        pricePerPerson = 22.50;
                    }
                    totalPrice = count * pricePerPerson;
                    if (count >= 10 && count <= 20)
                    {
                        totalPrice = totalPrice - totalPrice * 0.05;
                    }
                    break;
            }
            Console.WriteLine($"Total price: {totalPrice:F2}");
        }
    }
}
