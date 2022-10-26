using System;
using System.Collections.Generic;
using System.Text;

namespace _01.ListyIterator
{
    public class ListyIterator<T>
    {
        private IReadOnlyList<T> list;
        private int index = 0;

        public ListyIterator(params T[] list)
        {
            this.list = new List<T>(list);
        }
        public ListyIterator()
        {

        }

        public bool Move()
        {
            if (index < list.Count - 1)
            {
                index++;
                return true;
            }
            return false;
        }

        public bool HasNext() => index < list.Count - 1;
        public void Print()
        {
            if (index < 0 || index >= list.Count)
            {
                Console.WriteLine("Invalid Operation!");
                return;
            }
            Console.WriteLine(list[index]);
        }
    }
}
