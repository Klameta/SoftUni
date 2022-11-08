using System;
using System.Collections.Generic;
using System.Text;

namespace _04.PizzaCalories
{
    public class Pizza
    {
        private string name;
        private string dough;

        public string Name
        {
            get { return name; }
            private set { name = value; }
        }

        public string Dough
        {
            get { return dough; }
            set { dough = value; }
        }
        private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }


    }
}
