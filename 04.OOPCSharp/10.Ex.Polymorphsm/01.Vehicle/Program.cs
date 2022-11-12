using System;

namespace _01.Vehicle
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] carInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Car car = new Car(double.Parse(carInfo[1]), double.Parse(carInfo[2]));

            string[] truckInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Truck truck = new Truck(double.Parse(truckInfo[1]), double.Parse(truckInfo[2]));

            int lines = int.Parse(Console.ReadLine());
            for (int i = 0; i < lines; i++)
            {
                string[] cmdArgs = Console.ReadLine().Split();
                double amount = double.Parse(cmdArgs[2]);
                switch (cmdArgs[0])
                {
                    case "Refuel":
                        if (cmdArgs[1] == "Car")
                        {
                            car.Refuel(amount);
                        }
                        else
                        {
                            truck.Refuel(amount);
                        }
                        break;
                    case "Drive":
                        if (cmdArgs[1] == "Car")
                        {
                            car.Drive(amount);
                        }
                        else
                        {
                            truck.Drive(amount);
                        }
                        break;
                }
            }
            Console.WriteLine(car);
            Console.WriteLine(truck);
        }
    }
}
