using System;
using System.Collections.Generic;
using System.Text;

namespace BoxOfT
{
    public class Box<T>
    {
        public Box()
        {
            Values = new List<T>();
        }
        public List<T> Values { get; set; }

        public void Add(T element)
        {
            Values.Add(element);
        }

        public T Remove()
        {
            T result = Values[Values.Count - 1];
            Values.Remove(result);

            return result;
        }

        public int Count { get { return Values.Count; } }
    }
}
