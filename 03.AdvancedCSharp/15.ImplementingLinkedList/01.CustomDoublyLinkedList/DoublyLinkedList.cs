using System;
using System.Collections.Generic;
using System.Text;

namespace CustomDoublyLinkedList
{
    public class DoublyLinkedList
    {
        private ListNode head;
        private ListNode tail;

        public int Count { get; set; }

        public void AddFist(int element)
        {
            ListNode newNode = new ListNode(element);

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
        public void AddLast(int element)
        {
            ListNode newNode = new ListNode(element);

            if (Count == 0)
            {
                head = tail = newNode;
                Count++;
            }
            else
            {

                tail.Next = newNode;
                newNode.Previous = tail;
                newNode = tail;
            }
            Count++;
        }
        public int RemoveFirst()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException();
            }

            var removed = head;
            if (Count == 1)
            {
                head = tail = null;
                Count--;
            }
            else
            {
                head = head.Next;
                head.Previous = null;
            }
            Count--;
            return removed.Value;
        }
        public int RemoveLast()
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
        public void ForEach(Action<int> action)
        {
            var temp = head;
            while (temp.Next!=null)
            {
                action(temp.Value);
                temp = temp.Next;
            }
        }
        public int[] ToArray()
        {
            var array = new int[Count];
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
