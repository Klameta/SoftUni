using System;
using System.Collections.Generic;
using System.Text;

namespace _05.GenericCountMethodString
{
    public class Box<T> where T : IComparable
    {

        private List<T> items;

        public List<T> Items
        {
            get { return items; }
            set { items = value; }
        }

        public Box()
        {
            items = new List<T>();
        }

        public int CompareCount(T compaper)
        {
            int result = 0;
            foreach (var item in Items)
            {
                if (item.CompareTo(compaper)>0)
                {
                    result++;
                }
            }

            return result;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            foreach (var item in Items)
            {
                result.Append($"{item.GetType().FullName}: {item}");
            }
            return result.ToString().TrimEnd();
        }
    }
}
