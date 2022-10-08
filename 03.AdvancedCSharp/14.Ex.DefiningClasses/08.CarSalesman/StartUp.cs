using System;
using System.Collections.Generic;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Dictionary<string,Engine> engines = new Dictionary<string, Engine>();
            int enginesCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < enginesCount; i++)
            {
                string[] engineInfo = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = engineInfo[0];
                int power = int.Parse(engineInfo[1]);
                int discplacment = 0;
                string efficiency = string.Empty;
                Engine engine = new Engine(model,power);

                if (engineInfo.Length == 4)
                {
                    if (int.TryParse(engineInfo[2], out int result))
                    {
                        discplacment = int.Parse(engineInfo[2]);
                        efficiency = engineInfo[3];
                        
                    }
                    else
                    {
                        efficiency = engineInfo[2];
                        discplacment = int.Parse(engineInfo[3]);

                    }
                    engine.Displacement = discplacment;
                    engine.Efficiency = efficiency;
                }
                else if (engineInfo.Length==3)
                {
                    if (int.TryParse(engineInfo[2], out int result))
                    {
                        discplacment = int.Parse(engineInfo[2]);
                        engine.Displacement = discplacment;
                    }
                    else
                    {
                        efficiency = engineInfo[2];
                        engine.Efficiency = efficiency; 
                    }
                }
                engines.Add(model, engine);
            }
            Console.WriteLine();

            int carLines = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < carLines; i++)
            {
                string[] carInfo = Console.ReadLine()
                                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = carInfo[0];
                string engine = carInfo[1];
                int weight = 0;
                string color = string.Empty;
                Car car = new Car(model, engines[engine]);

                if (carInfo.Length == 4)
                {
                    if (int.TryParse(carInfo[2], out int result))
                    {
                        weight = int.Parse(carInfo[2]);
                        color = carInfo[3];

                    }
                    else
                    {
                        color = carInfo[2];
                        weight = int.Parse(carInfo[3]);

                    }
                    car.Weight = weight;
                    car.Color = color;
                }
                else if(carInfo.Length == 3) 
                {
                    if (int.TryParse(carInfo[2], out int result))
                    {
                        weight = int.Parse(carInfo[2]);
                        car.Weight = weight;
                    }
                    else
                    {
                        color = carInfo[2];
                        car.Color = color;
                    }
                }
                cars.Add(car);
            }
            Console.WriteLine(string.Join(Environment.NewLine, cars));
        }
    }
}
