using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < lines; i++)
            {
                string[] carInfo = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = carInfo[0];
                int engineSpeed = int.Parse(carInfo[1]);
                int enginePower = int.Parse(carInfo[2]);
                Engine engine = new Engine(engineSpeed, enginePower);

                int cargoWeight = int.Parse(carInfo[3]);
                string cargoType = carInfo[4];
                Cargo cargo = new Cargo(cargoType, cargoWeight);

                Tire[] tires = new Tire[4];
                int counter = 0;

                for (int k = 0; k < 8; k += 2)
                {
                    double tirePressure = double.Parse(carInfo[k + 5]);
                    int tireAge = int.Parse(carInfo[k + 5 + 1]);
                    Tire tire = new Tire(tireAge, tirePressure);
                    tires[counter] = tire;
                    counter++;
                }

                Car car = new Car(model, engine, cargo, tires);
                cars.Add(car);
            }

            string type = Console.ReadLine();

            Predicate<Tire> isPressureLessThanOne = tire => tire.Pressure < 1;

            if (type == "fragile")
            {
                for (int i = 0; i < cars.Count; i++)
                {
                    bool temp = false;
                    foreach (var tire in cars[i].Tires)
                    {
                        if (tire.Pressure < 1)
                        {
                            temp = true;
                        }
                    }

                    if (temp)
                    {
                        Console.WriteLine(cars[i]);
                    }
                }

            }
            else
            {
                cars = cars.Where(x => x.EngineOfCar.Power > 250).ToList();
                Console.WriteLine(string.Join(Environment.NewLine, cars));
            }
        }

        private static bool mMoreThanOne(List<Car> cars, int i, bool moreThanOneTire)
        {
            foreach (var tire in cars[i].Tires)
            {
                if (tire.Pressure < 1)
                {
                    moreThanOneTire = true;
                }
            }

            return moreThanOneTire;
        }
    }
}
