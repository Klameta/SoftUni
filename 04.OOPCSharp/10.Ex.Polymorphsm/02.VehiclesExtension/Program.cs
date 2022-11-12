using System;
using System.IO;

namespace _02.VehiclesExtension
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] carInfo = Console.ReadLine().Split(' ');
            Car car = new Car(double.Parse(carInfo[1]), double.Parse(carInfo[2]), double.Parse(carInfo[3]));

            string[] truckInfo = Console.ReadLine().Split();
            Truck truck = new Truck(double.Parse(truckInfo[1]), double.Parse(truckInfo[2]), double.Parse(truckInfo[3]));

            string[] busInfo = Console.ReadLine().Split();
            Bus bus = new Bus(double.Parse(busInfo[1]), double.Parse(busInfo[2]), double.Parse(busInfo[3]));



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
                        else if (cmdArgs[1] == "Truck")
                        {
                            truck.Refuel(amount);
                        }
                        else
                        {
                            bus.Refuel(amount);
                        }
                        break;
                    case "Drive":
                        if (cmdArgs[1] == "Car")
                        {
                            car.Drive(amount);
                        }
                        else if (cmdArgs[1] == "Truck")
                        {
                            truck.Drive(amount);
                        }
                        else
                        {
                            bus.Drive(amount);
                        }
                        break;
                    default:
                        bus.DriveEmpty(amount);
                        break;
                }
            }
            Console.WriteLine(car);
            Console.WriteLine(truck);
            Console.WriteLine(bus);
        }
    }
}
