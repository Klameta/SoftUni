using System;
using System.Collections.Generic;
using System.Text;

namespace _05.BirthdayCelebrations
{
    public class Citizen : IIndetifiable, IBirthable
    {
        public Citizen(string name, int age, string id, string birthdate)
        {
            Name = name;
            Age = age;
            Id = id;
            Birthdate = birthdate;
        }

        public override string ToString()
        {
            return $"{Birthdate}";
        }

        public string Name { get; set; }
        public string Id { get; set; }
        public int Age { get; set; }
        public string Birthdate { get; set; }
    }
}
