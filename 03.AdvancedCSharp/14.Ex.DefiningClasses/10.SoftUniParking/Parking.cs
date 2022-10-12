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
        public Parking(int capacity)
        {
            Capacity = capacity;
            Cars = new List<Car>();

        }

        public List<Car> Cars
        {
            get { return cars; }
            set { cars = value; }
        }
        public int Capacity
        {
            get { return capacity; }
            private set { capacity = value; }
        }
        public int Count { get; set; }

        public string AddCar(Car Car)
        {
            if (Cars.Any(x => x.RegistrationNumber == Car.RegistrationNumber))
            {
                return "Car with that registration number, already exists!";
            }

            if (Cars.Count == Capacity)
            {
                return "Parking is full!";
            }

            Cars.Add(Car);
            Count++;
            return $"Successfully added new car {Car.Make} {Car.RegistrationNumber}";
        }
        public string RemoveCar(string RegistrationNumber)
        {
            if (Cars.Any(x => x.RegistrationNumber == RegistrationNumber))
            {
                Car removedCar = Cars.Find(x => x.RegistrationNumber == RegistrationNumber);
                Cars.Remove(removedCar);
                Count--;
                return $"Successfully removed {RegistrationNumber}";
            }

            return "Car with that registration number, doesn't exist!";
        }
        public Car GetCar(string RegistrationNumber)
        {
            return Cars.Find(x => x.RegistrationNumber == RegistrationNumber);
        }

        public void RemoveSetOfRegistrationNumber(List<string> RegistrationNumbers)
        {
            foreach (var regNum in RegistrationNumbers)
            {
                Console.WriteLine(RemoveCar(regNum));
            }
        }
    }
}
