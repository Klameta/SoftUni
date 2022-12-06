namespace CarManager.Tests
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class CarManagerTests
    {
        Car car;
        [SetUp]
        public void SetUp()
        {
            car = new Car("asd", "dsa", 2.2, 20);
        }
        [Test]
        public void ConstructorsShouldAssingValuesCorrectly()
        {
            string make = "asd";
            string model = "dsa";
            double fuel = 2.2;
            double capacity = 20;
            car = new Car(make, model, fuel, capacity);

            var actualMake = car.Make;
            var actualModel = car.Model;
            var actualFuel = car.FuelConsumption;
            var actualCap = car.FuelCapacity;

            Assert.IsTrue(make == actualMake && model == actualModel && fuel == actualFuel && capacity == actualCap && car.FuelAmount == 0);
        }

        [Test]
        [TestCase("")]
        [TestCase(null)]
        public void MakeShouldNotWork(string data)
        {

            Assert.Throws<ArgumentException>(() =>
            {
                car = new Car(data, "dsa", 2.2, 20);
            });
        }
        
        [Test]
        [TestCase("")]
        [TestCase(null)]
        public void ModelShouldNotWork(string data)
        {

            Assert.Throws<ArgumentException>(() =>
            {
                car = new Car("asd", data, 2.2, 20);
            });
        } 

        [Test]
        [TestCase(0)]
        [TestCase(-1)]
        public void FuelConsumptionShouldNotWork(double data)
        {

            Assert.Throws<ArgumentException>(() =>
            {
                car = new Car("asd", "dsa", data, 20);
            });
        }
        
        [Test]
        [TestCase(0)]
        [TestCase(-1)]
        public void FuelCapacityShouldNotWork(double data)
        {

            Assert.Throws<ArgumentException>(() =>
            {
                car = new Car("asd", "dsa", 2.2, data);
            });
        }

        [Test]
        [TestCase(0)]
        [TestCase(-1)]
        public void RefulingShouldNotWork(double data)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                car.Refuel(data);
            });
        }

        [Test]
        [TestCase(5)]
        [TestCase(1)]
        public void RefulingShouldWork(double data)
        {
            car.Refuel(data);

            Assert.AreEqual(data, car.FuelAmount);
        }

        [Test]
        [TestCase(21)]
        [TestCase(50)]
        public void RefulingCarShouldNotUpTheCapacity(double data)
        {
            car.Refuel(data);
            Assert.AreEqual(20, car.FuelAmount);
        }

        [Test]
        [TestCase(10000)]
        [TestCase(1000)]
        public void DrivingCarShouldNotWork(double data)
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                car.Drive(data);
            });
        }
        
        [Test]
        [TestCase(0)]
        [TestCase(10)]
        public void DrivingCarShouldWork(double data)
        {
            car.Refuel(20);

            double expected = car.FuelAmount-((data / 100) * car.FuelConsumption);

            car.Drive(data);

            Assert.AreEqual(expected, car.FuelAmount);
        }
       /* [Test]
        [TestCase(0)]
        [TestCase(-1)]
        [TestCase(-100)]
        public void DrivingShouldNotWork(double data)
        {
            car.Drive(data);

            double expected = 0;

            Assert.AreEqual(expected, car.FuelAmount);
        }*/
    }
}