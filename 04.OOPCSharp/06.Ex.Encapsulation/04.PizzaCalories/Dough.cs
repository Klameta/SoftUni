using System;
using System.Collections.Generic;
using System.Text;

namespace _04.PizzaCalories
{
    public class Dough
    {
        private const double BASE_CALORIES = 2.0;

        private const double WHITE_CALORIES = 1.5;
        private const double WHOLEGRAIN_CALORIES = 1.0;
        private const double CRISPY_CALORIES = 0.9;
        private const double CHEWY_CALORIES = 1.1;
        private const double HOMEMADE_CALORIES = 1.0;

        private string flourType;
        private string bakingTechnique;
        private double grams;

        public Dough(string flourType, string bakingTechnique, double grams)
        {
            FlourType = flourType;
            BakingTechnique = bakingTechnique;
            Grams = grams;
            Calories = CaloriesCalculator();
        }
        

        public override string ToString()
        {
            return $"{Calories:F2}";
        }

        private double CaloriesCalculator()
        {
            double flourMod = FlourType.ToLower() == "white" ? WHITE_CALORIES : WHOLEGRAIN_CALORIES;
            double bakingMod = BakingTechnique.ToLower() == "crispy" ? CRISPY_CALORIES :
                BakingTechnique.ToLower() == "chewy" ? CHEWY_CALORIES : HOMEMADE_CALORIES;

            return (Grams * BASE_CALORIES) * flourMod * bakingMod;
        }

        private string FlourType
        {
            get { return flourType; }
            set
            {
                if (!(value.ToLower() == "white" || value.ToLower() == "wholegrain")) throw new ArgumentException("Invalid type of dough.");
                flourType = value;
            }
        }
        private string BakingTechnique
        {
            get { return bakingTechnique; }
            set
            {
                if (!(value.ToLower() == "crispy" || value.ToLower() == "chewy" || value.ToLower() == "homemade")) throw new ArgumentException("Invalid type of dough.");
                bakingTechnique = value;
            }
        }
        private double Grams
        {
            get { return grams; }
            set
            {
                if (value < 1 || value > 200) throw new ArgumentException("Dough weight should be in the range [1..200].");
                grams = value;
            }
        }
        public double Calories { get; private set; }

    }
}
