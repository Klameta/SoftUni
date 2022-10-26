using System;
using System.Collections.Generic;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Dictionary<string, Car> cars = new Dictionary<string, Car>();
            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                string[] carInfo = Console.ReadLine()
                    .Split();

                Car car = new Car(carInfo[0], double.Parse(carInfo[1]),double.Parse(carInfo[2]));
                cars.Add(carInfo[0], car);
            }

            string[] cmdArgs = Console.ReadLine()
                .Split();

            while (cmdArgs[0]!="End")
            {
                string model = cmdArgs[1];
                double amountOfKm = double.Parse(cmdArgs[2]);

                cars[model].Drive(amountOfKm);
                cmdArgs = Console.ReadLine().Split();
            }

            foreach (var car in cars)
            {
                Console.WriteLine(car.Value);
            }
        }
    }
}
