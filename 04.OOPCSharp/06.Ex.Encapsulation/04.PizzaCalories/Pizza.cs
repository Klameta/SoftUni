using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04.PizzaCalories
{
    public class Pizza
    {
        private string name;
        private Dough dough;
        private List<Topping> toppings;

        public Pizza(string name)
        {
            Name = name;
            toppings = new List<Topping>();
        }

        public void AddToppings(Topping topping)
        {
            toppings.Add(topping);
        }
        public double GetCalories()
        {
            double calories = toppings.Sum(x => x.Calories) + dough.Calories;
            return calories;
        }
        public override string ToString()
        {
            return $"{Name} - {Calories:F2} Calories.";
        }

        public int ToppingCount
        {
            get
            {
                if (toppings.Count > 10) throw new ArgumentException("Number of toppings should be in range [0..10].");
                return toppings.Count;
            }
        }
        public double Calories { get { return GetCalories(); } }
        public string Name
        {
            get { return name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 1 || value.Length > 15) throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                name = value;
            }
        }
        public Dough Dough
        {
            get { return dough; }
            set { dough = value; }
        }
    }
}
