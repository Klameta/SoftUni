using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renovators
{
    public class Renovator
    {
        private string name;
        private string type;
        private double rate;
        private int days;
        private bool hired;

        public Renovator(string name, string type, double rate, int days)
        {
            Name = name;
            Type = type;
            Rate = rate;
            Days = days;
            Hired = false;
        }

        public string Name
        {
            get { return name; }
           private set { name = value; }
        }
        public string Type
        {
            get { return type; }
           private set { type = value; }
        }
        public double Rate
        {
            get { return rate; }
           private set { rate = value; }
        }
        public int Days
        {
            get { return days; }
           private set { days = value; }
        }
        public bool Hired
        {
            get { return hired; }
            set { hired = value; }
        }

        public override string ToString()
        {
            return $"-Renovator: {name}" +
                $"\n--Specialty: {type}" +
                $"\n--Rate per day: {rate} BGN";
        }
    }
}
