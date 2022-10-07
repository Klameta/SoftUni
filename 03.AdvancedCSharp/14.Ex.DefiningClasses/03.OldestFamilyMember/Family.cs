using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    internal class Family
    {
        public List<Person> People { get; set; }

        public Family()
        {
            People = new List<Person>();
        }

        public void AddMember(Person person)
        {
            People.Add(person);
        }

        public Person GetOldestMember()
        {
            Person oldest = new Person();
            foreach (var member in People)
            {
                if (member.Age >= oldest.Age)
                {
                    oldest = member;
                }
            }
            return oldest;
        }
    }
}
