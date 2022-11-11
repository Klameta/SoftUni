using System;
using System.Collections.Generic;
using System.Text;

namespace _05.BirthdayCelebrations
{
    public class Pet : IBirthable
    {
        public Pet(string name, string birthdate)
        {
            Name = name;
            Birthdate = birthdate;
        }

        public override string ToString()
        {
            return $"{Birthdate}";
        }
        public string Name { get; set; }
        public string Birthdate { get; set; }
    }
}
