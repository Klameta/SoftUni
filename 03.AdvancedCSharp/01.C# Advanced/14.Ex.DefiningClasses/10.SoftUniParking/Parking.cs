using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniParking
{
    public class Parking
    {
        private List<Car> cars;
        private int capacity;
        public Parking(int cap)
        {
            capacity = cap;
            cars = new List<Car>();

        }

        public int Count => cars.Count;

        public string AddCar(Car Car)
        {
            if (cars.Any(x => x.RegistrationNumber == Car.RegistrationNumber))
            {
                return "Car with that registration number, already exists!";
            }

            if (cars.Count == capacity)
            {
                return "Parking is full!";
            }

            cars.Add(Car);
            //Count++;
            return $"Successfully added new car {Car.Make} {Car.RegistrationNumber}";
        }
        public string RemoveCar(string RegistrationNumber)
        {
            if (cars.Any(x => x.RegistrationNumber == RegistrationNumber))
            {
                Car removedCar = cars.Find(x => x.RegistrationNumber == RegistrationNumber);
                cars.Remove(removedCar);
                //Count--;
                return $"Successfully removed {RegistrationNumber}";
            }

            return "Car with that registration number, doesn't exist!";
        }
        public Car GetCar(string RegistrationNumber)
        {
            return cars.Find(x => x.RegistrationNumber == RegistrationNumber);
        }

        public void RemoveSetOfRegistrationNumber(List<string> RegistrationNumbers)
        {
            foreach (var regNum in RegistrationNumbers)
            {
                RemoveCar(regNum);
            }
        }
    }
}
