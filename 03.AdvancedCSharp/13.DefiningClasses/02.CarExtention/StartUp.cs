using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Car car = new Car();
            car.Model = "VW";
            car.Make = "MK3";
            car.Year = 1992;
            car.FuelQuantity = 200;
            car.FuelConsuption = 200;
            car.Drive(200);

            Console.WriteLine(car.WhoAmI());
        }

    }
}
