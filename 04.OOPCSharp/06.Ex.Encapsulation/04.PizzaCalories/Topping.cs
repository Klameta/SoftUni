using System;
using System.Collections.Generic;
using System.Text;

namespace _04.PizzaCalories
{
    public class Topping
    {
        private const double BASE_MOD = 2;

        private const double MEAT_MOD = 1.2;
        private const double VEG_MOD = 0.8;
        private const double CHEESE_MOD = 1.1;
        private const double SAUCE_MOD = 0.9;

        private string type;
        private double grams;

        public Topping(string type, double grams)
        {
            Type = type;
            Grams = grams;
            Calories = CaloriesCalculator();
        }

        private double CaloriesCalculator()
        {
            double typeMod = type == "Meat" ? MEAT_MOD :
                type == "Veggies" ? VEG_MOD :
                type == "Cheese" ? CHEESE_MOD :
                SAUCE_MOD;

            return (Grams * BASE_MOD) * typeMod;
        }

        public override string ToString()
        {
            return $"{Calories:F2}";
        }

        private string Type
        {
            get { return type; }
            set
            {
                if (!(value == "Meat" || value == "Veggies" || value == "Cheese" || value == "Sauce")) throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                type = value;
            }
        }
        private double Grams
        {
            get { return grams; }
            set
            {
                if (value < 1 || value > 50) throw new ArgumentException($"{Type} weight should be in the range[1..50].");
                grams = value;
            }
        }
        public double Calories { get; private set; }


    }
}
