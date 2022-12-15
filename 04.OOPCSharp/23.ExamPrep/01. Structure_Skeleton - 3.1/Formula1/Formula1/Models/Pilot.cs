﻿using Formula1.Models.Contracts;
using Formula1.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Formula1.Models
{
    public class Pilot : IPilot
    {
        private string fullName;
        private IFormulaOneCar car;
        private int numberOfWins;

        public Pilot(string fullName)
        {
            FullName = fullName;
            CanRace = false;
        }

        public string FullName
        {
            get { return fullName; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 5) throw new ArgumentException(string.Format(ExceptionMessages.InvalidPilot, value));
                fullName = value;
            }
        }
        public IFormulaOneCar Car
        {
            get { return car; }
            private set
            {
                if (value == null) throw new NullReferenceException(ExceptionMessages.InvalidCarForPilot);
                car = value;
            }
        }
        public int NumberOfWins
        {
            get { return numberOfWins; }
            private set
            {
                numberOfWins = value;
            }
        }
        public bool CanRace { get; private set; }

        public void AddCar(IFormulaOneCar car)
        {
            Car = car;
            CanRace = true;
        }

        public void WinRace()
        {
            numberOfWins++;
        }
        public override string ToString()
        {
            return $"Pilot {fullName} has {numberOfWins} wins.";
        }
    }
}
