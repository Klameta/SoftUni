using System;
using System.Collections.Generic;
using System.Text;

namespace _04.BorderControl
{
    public class Robot : IIndetifiable
    {
        public Robot(string model, string id)
        {
            Model = model;
            Id = id;
        }

        public override string ToString()
        {
            return $"{Id}";
        }

        public string Model { get; set; }
        public string Id { get; set; }
    }
}
