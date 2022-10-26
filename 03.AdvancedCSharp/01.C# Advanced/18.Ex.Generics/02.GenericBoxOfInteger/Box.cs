using System;
using System.Collections.Generic;
using System.Text;

namespace _01.GenericBoxOfString
{
    public class Box<T>
    {
        private T item;

        public Box(T item)
        {
            Item = item;
        }

        public T Item
        {
            get { return item; }
            set { item = value; }
        }

        public override string ToString()
        {
            return $"{item.GetType().FullName}: {item}";
        }
    }
}
