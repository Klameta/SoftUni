using System;

namespace CustomDoublyLinkedList
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            DoublyLinkedList doublyLinkedList = new DoublyLinkedList();
            doublyLinkedList.AddFist(4);
            doublyLinkedList.AddFist(8);
            doublyLinkedList.AddFist(7);
            doublyLinkedList.AddFist(2);
            Console.WriteLine(doublyLinkedList.RemoveLast());

            Console.WriteLine(String.Join(" ", doublyLinkedList.ToArray()));
        }
    }
}
