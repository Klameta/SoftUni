using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Animal
    {
        private string name;
        private int age;
        private string gender;

        public Animal(string name, int age, string gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (value == null) throw new ArgumentException("Invalid input!");
                name = value;

            }
        }
        public virtual int Age
        {
            get { return age; }
            set
            {
                if (value <= 0) throw new ArgumentException("Invalid input!");
                age = value;

            }
        }
        public string Gender
        {
            get { return gender; }
            set
            {
                if (value == null) throw new ArgumentException("Invalid input!");
                gender = value;

            }
        }

        public virtual string ProduceSound()=> null;
        public override string ToString()
        {
            return $"{GetType().Name}" +
                $"\n{Name} {Age} {Gender}" +
                $"\n{ProduceSound()}";
        }
    }
}
