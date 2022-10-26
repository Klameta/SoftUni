using System;
using System.Collections.Generic;
using System.Text;

namespace _07.Tuple
{
    public class Threeuple<T, Y, Z>
    {
        private T item1;
        private Y item2;

      
        public T Item1
        {
            get { return item1; }
            set { item1 = value; }
        }
        public Y Item2
        {
            get { return item2; }
            set { item2 = value; }
        }
        private Z item3;
        public Threeuple(T item1, Y item2, Z item3)
        {
            Item1 = item1;
            Item2 = item2;
            Item3 = item3;
        }

        public Z Item3
        {
            get { return item3; }
            set { item3 = value; }
        }
        public override string ToString()
        {
            return $"{item1} -> {item2} -> {item3}";
        }
    }
}
