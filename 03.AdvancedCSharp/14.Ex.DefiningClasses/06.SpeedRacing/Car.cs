using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Car
    {
		private string model;
		private double fuelAmount;
		private double fuelConsumptionPerKilometer;
		private double travelledDistance = 0	;

		public Car(string model, double fuelAmount, double fuelConsumptionPerKilometer)
		{
			Model = model;
			FuelAmount = fuelAmount;
			FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
		}

		public string Model
		{
			get { return model; }
			set { model = value; }
		}
		public double FuelAmount
		{
			get { return fuelAmount; }
			set { fuelAmount = value; }
		}
		public double FuelConsumptionPerKilometer
        {
			get { return fuelConsumptionPerKilometer; }
			set { fuelConsumptionPerKilometer = value; }
		}
		public double TravelledDistance
		{
			get { return travelledDistance; }
			set { travelledDistance = value; }
		}

		public void Drive(double amountOfKm)
		{
            var kmNeeded = FuelConsumptionPerKilometer * amountOfKm;

            if (kmNeeded <= this.FuelAmount)
            {
                this.fuelAmount -= kmNeeded;
				this.travelledDistance += amountOfKm;
            }
            else
            {
                Console.WriteLine($"Insufficient fuel for the drive");
            }
        }

		public override string ToString()
		{
			return $"{this.Model} {this.FuelAmount:F2} {this.TravelledDistance}";
		}
	}
}
