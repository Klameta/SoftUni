using System;
using System.Collections.Generic;
using System.Text;

namespace _06.FoodShortage
{
    public class Citizen : IIndetifiable, IBirthable, IBuyer
    {
        public Citizen(string name, int age, string id, string birthdate)
        {
            Name = name;
            Age = age;
            Id = id;
            Birthdate = birthdate;
            Food = 0;
        }

        public override string ToString()
        {
            return $"{Birthdate}";
        }

       
        public int BuyFood()
        {
            Food += 10;

            return 10;
        }

        public string Name { get; set; }
        public string Id { get; set; }
        public int Age { get; set; }
        public string Birthdate { get; set; }
        public int Food { get;private set; }
    }
}
