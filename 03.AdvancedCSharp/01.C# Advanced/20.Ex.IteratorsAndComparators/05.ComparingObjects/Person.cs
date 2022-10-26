using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace _05.ComparingObjects
{
    public class Person : IComparable<Person>
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }

        public Person(string name, int age, string city)
        {
            Name = name;
            Age = age;
            City = city;
        }

        public int CompareTo([AllowNull] Person other)
        {
            if (this.Name == other.Name && this.Age == other.Age && this.City == other.City)
            {
                return 0;
            }
            return 1;
        }
    }
}
