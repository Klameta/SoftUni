using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _03.Stack
{
    public class Stack<T> : IEnumerable<T>
    {
        private readonly List<T> list;

        public Stack(params T[] list)
        {
            this.list = new List<T>(list);
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = list.Count - 1; i >= 0; i--)
            {
                yield return list[i];
            }
        }
        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();

        public void Push(params T[] values)
        {
            for (int i = 0; i < values.Length; i++)
            {
                list.Add(values[i]);
            }
        }
        public void Pop()
        {
            if (list.Count < 1)
            {
                Console.WriteLine("No elements");
                return;
            }
            list.RemoveAt(list.Count - 1);
        }
    }
}
