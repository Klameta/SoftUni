using System;

namespace _11
{
    class Program
    {
        static void Main(string[] args)
        {

            var name = Console.ReadLine();
            var dayOfWeek = Console.ReadLine();
            var howMuch = double.Parse(Console.ReadLine());
            double price = 1.00;
            int error = 0;
            switch (dayOfWeek)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    switch (name)
                    {
                        case "banana":
                            price *= 2.50 * howMuch;
                            break;
                        case "apple":
                            price *= 1.20 * howMuch;
                            break;
                        case "orange":
                            price *= 0.85 * howMuch;
                            break;
                        case "grapefruit":
                            price *= 1.45 * howMuch;
                            break;
                        case "kiwi":
                            price *= 2.70 * howMuch;
                            break;
                        case "pineapple":
                            price *= 5.50 * howMuch;
                            break;
                        case "grapes":
                            price *= 3.85 * howMuch;
                            break;
                        default:
                            Console.WriteLine("error");
                            error++;
                            break;
                    }
                    break;

                case "Saturday":
                case "Sunday":
                    switch (name)
                    {
                        case "banana":
                            price *= 2.70 * howMuch;
                            break;
                        case "apple":
                            price *= 1.25 * howMuch;
                            break;
                        case "orange":
                            price *= 0.90 * howMuch;
                            break;
                        case "grapefruit":
                            price *= 1.60 * howMuch;
                            break;
                        case "kiwi":
                            price *= 3.00 * howMuch;
                            break;
                        case "pineapple":
                            price *= 5.60 * howMuch;
                            break;
                        case "grapes":
                            price *= 4.20 * howMuch;
                            break;
                        default:
                            Console.WriteLine("error");
                            error++;
                            break;

                    }
                    break;

                default:
                    Console.WriteLine("error");
                    error++;
                    break;

            }
            if(error==0)
            Console.WriteLine($"{price:F2}");
        }
    }
}
