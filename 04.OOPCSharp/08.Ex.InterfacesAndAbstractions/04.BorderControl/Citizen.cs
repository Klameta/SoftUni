﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _04.BorderControl
{
    public class Citizen : IIndetifiable
    {
        public Citizen(string name, int age, string id)
        {
            Name = name;
            Age = age;
            Id = id;
        }

        public override string ToString()
        {
            return $"{Id}";
        }

        public string Name { get; set; }
        public string Id { get; set; }
        public int Age { get; set; }


    }
}
