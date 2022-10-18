using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renovators
{
    public class Catalog
    {
        private List<Renovator> renovators;

        private string name;
        private int neededRenovators;
        private string project;

        public Catalog(string name, int neededRenovators, string project)
        {
            Name = name;
            NeededRenovators = neededRenovators;
            Project = project;
            renovators = new List<Renovator>();
        }

        public string Name
        {
            get { return name; }
            private set { name = value; }
        }
        public int NeededRenovators
        {
            get { return neededRenovators; }
            private set { neededRenovators = value; }
        }
        public string Project
        {
            get { return project; }
            private set { project = value; }
        }
        public int Count => renovators.Count();
        public string AddRenovator(Renovator renovator)
        {
            if (Count < NeededRenovators)
            {
                if (renovator.Name == null || renovator.Type == null) return "Invalid renovator's information.";
                if (renovator.Rate > 350) return "Invalid renovator's rate.";

                renovators.Add(renovator);
                return $"Successfully added {renovator.Name} to the catalog.";
            }
            return "Renovators are no more needed.";
        }
        public bool RemoveRenovator(string name)
        {
            var currRenovator = renovators.FirstOrDefault(x => x.Name == name);
            if (currRenovator == null) return false;

            renovators.Remove(currRenovator);
            return true;
        }
        public int RemoveRenovatorBySpecialty(string type)
        {
            int count = renovators.Count();
            renovators = renovators.Where(x => x.Type != type).ToList();
            count -= renovators.Count();

            return count;
        }
        public Renovator HireRenovator(string name)
        {
            var currRenovator = renovators.FirstOrDefault(x => x.Name == name);
            if (currRenovator == null) return null;

            currRenovator.Hired = true;
            return currRenovator;
        }
        public List<Renovator> PayRenovators(int days)
        {
            return renovators.Where(x => x.Days >= days).ToList();
        }
        public string Report()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Renovators available for Project {project}:");

            foreach (var renovator in renovators.Where(x => x.Hired == false).ToList())
            {
                stringBuilder.AppendLine(renovator.ToString());
            }

            return stringBuilder.ToString().TrimEnd();
        }
    }
}
