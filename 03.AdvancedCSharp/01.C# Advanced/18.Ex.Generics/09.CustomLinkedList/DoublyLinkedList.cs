using System;
using System.Collections.Generic;
using System.Text;

namespace CustomDoublyLinkedList
{
    public class DoublyLinkedList<T>
    {
        private ListNode<T> head;
        private ListNode<T> tail;

        public int Count { get;private set; }

        public void AddFirst(T element)
        {
            ListNode<T> newNode = new ListNode<T>(element);

            if (Count == 0)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                newNode.Next = head;
                head.Previous = newNode;
                head = newNode;
            }

            Count++;
        }
        public void AddLast(T element)
        {
            ListNode<T> newNode = new ListNode<T>(element);

            if (Count == 0)
            {
                head = tail = newNode;
            }
            else
            {

                tail.Next = newNode;
                newNode.Previous = tail;
                tail = newNode;
            }
            Count++;
        }
        public T RemoveFirst()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException();
            }

            var removed = head;
            if (Count == 1)
            {
                head = tail = null;
            }
            else
            {
                head = head.Next;
                head.Previous = null;

            }
            Count--;
            return removed.Value;
        }
        public T RemoveLast()
        {
            if (Count==0)
            {
                throw new InvalidOperationException();
            }

            var removed = tail;
            tail = tail.Previous;
            if (Count==1)
            {
                tail = head = null;
            }
            else
            {
                tail.Next = null;
            }
            Count--;
            return removed.Value;
        }
        public void ForEach(Action<T> action)
        {
            var temp = head;
            while (temp.Next!=null)
            {
                action(temp.Value);
                temp = temp.Next;
            }
            action(temp.Value);
        }
        public T[] ToArray()
        {
            var array = new T[Count];
            var temp = head;

            for (int i = 0; i < Count; i++)
            {
                array[i] = temp.Value;
                temp = temp.Next;
            }
            return array;
        }

    }
}
