using System;

namespace CustomDoublyLinkedList
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            DoublyLinkedList doublyLinkedList = new DoublyLinkedList();
            doublyLinkedList.AddFirst(4);
            doublyLinkedList.AddFirst(8);
            doublyLinkedList.AddFirst(7);
            doublyLinkedList.AddFirst(2);
            Console.WriteLine(doublyLinkedList.RemoveLast());

            Console.WriteLine(String.Join(" ", doublyLinkedList.ToArray()));
        }
    }
}
