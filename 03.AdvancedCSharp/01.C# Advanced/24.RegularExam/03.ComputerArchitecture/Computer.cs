using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComputerArchitecture
{
    public class Computer
    {
        private string model;
        private int capacity;
        private List<CPU> multiprocessor;

        public Computer(string model, int capacity)
        {
            Model = model;
            Capacity = capacity;
            multiprocessor = new List<CPU>();
        }

        public int Count => multiprocessor.Count;

        public void Add(CPU cpu)
        {
            if (Count < capacity)
            {
                multiprocessor.Add(cpu);

            }
        }
        public bool Remove(string brand)
        {
            var temp = multiprocessor.FirstOrDefault(x => x.Brand == brand);
            if (temp == null)
            {
                return false;
            }
            multiprocessor.Remove(temp);
            return true;
        }
        public CPU MostPowerful()
        {
            return multiprocessor.OrderByDescending(x => x.Frequency).First();
        }
        public CPU GetCPU(string brand) => multiprocessor.FirstOrDefault(x => x.Brand == brand);

        public string Report()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"CPUs in the Computer {model}:");

            foreach (var cpu in multiprocessor)
            {
                stringBuilder.AppendLine(cpu.ToString());
            }

            return stringBuilder.ToString().TrimEnd();
        }

        public string Model
        {
            get { return model; }
            private set { model = value; }
        }
        public int Capacity
        {
            get { return capacity; }
            private set { capacity = value; }
        }
        public List<CPU> Multiprocessor => multiprocessor;

    }
}
