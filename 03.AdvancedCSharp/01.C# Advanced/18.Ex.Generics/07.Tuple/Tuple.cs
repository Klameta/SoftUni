using System;
using System.Collections.Generic;
using System.Text;

namespace _07.Tuple
{
    public class Tuple<T, Y>
    {
        private T item1;
        private Y item2;

        public Tuple(T item1, Y item2)
        {
            Item1 = item1;
            Item2 = item2;
        }

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

        public override string ToString()
        {
            return $"{item1} -> {item2}";
        }
    }
}
