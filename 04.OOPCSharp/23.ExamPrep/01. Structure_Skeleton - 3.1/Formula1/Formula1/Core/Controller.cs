using Formula1.Core.Contracts;
using Formula1.Models;
using Formula1.Models.Contracts;
using Formula1.Repositories;
using Formula1.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Formula1.Core
{
    internal class Controller : IController
    {
        PilotRepository pilotRepository;
        RaceRepository raceRepository;
        FormulaOneCarRepository carRepository;
        public Controller()
        {
            pilotRepository = new PilotRepository();
            raceRepository = new RaceRepository();
            carRepository = new FormulaOneCarRepository();
        }

        public string AddCarToPilot(string pilotName, string carModel)
        {
            var pilot = pilotRepository.FindByName(pilotName);
            var car = carRepository.FindByName(carModel);

            if (pilot == null || pilot.CanRace) throw new InvalidOperationException(string.Format(ExceptionMessages.PilotDoesNotExistOrHasCarErrorMessage, pilotName));

            if (car == null) throw new NullReferenceException(string.Format(ExceptionMessages.CarDoesNotExistErrorMessage, carModel));

            pilot.AddCar(car);
            return String.Format(OutputMessages.SuccessfullyPilotToCar, pilotName, car.GetType().Name, carModel);
        }

        public string AddPilotToRace(string raceName, string pilotFullName)
        {
            throw new NotImplementedException();
        }

        public string CreateCar(string type, string model, int horsepower, double engineDisplacement)
        {
            if (carRepository.FindByName(model) != null) throw new InvalidOperationException(string.Format(ExceptionMessages.CarExistErrorMessage, model));

            IFormulaOneCar car;
            if (type == "Ferrari")
            {
                car = new Ferrari(model, horsepower, engineDisplacement);
            }
            else if (type == "Williams")
            {
                car = new Williams(model, horsepower, engineDisplacement);
            }
            else
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.InvalidTypeCar, type));
            }

            carRepository.Add(car);
            return string.Format(OutputMessages.SuccessfullyCreateCar, type, model);

        }

        public string CreatePilot(string fullName)
        {
            if (pilotRepository.FindByName(fullName) != null) throw new InvalidOperationException(string.Format(ExceptionMessages.PilotExistErrorMessage, fullName));

            Pilot pilot = new Pilot(fullName);
            pilotRepository.Add(pilot);

            return string.Format(OutputMessages.SuccessfullyCreatePilot, fullName);

        }

        public string CreateRace(string raceName, int numberOfLaps)
        {
            IRace race;
            if (raceRepository.FindByName(raceName) != null) throw new InvalidOperationException(string.Format(ExceptionMessages.RaceExistErrorMessage, raceName));

            race = new Race(raceName, numberOfLaps);
            raceRepository.Remove(race);

            return string.Format(OutputMessages.SuccessfullyCreateRace, raceName);
        }

        public string PilotReport()
        {
            throw new NotImplementedException();
        }

        public string RaceReport()
        {
            throw new NotImplementedException();
        }

        public string StartRace(string raceName)
        {
            throw new NotImplementedException();
        }
    }
}
