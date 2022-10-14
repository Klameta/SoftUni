using System;

namespace CustomDoublyLinkedList
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            DoublyLinkedList<int> nums = new DoublyLinkedList<int>();

            nums.AddLast(1);
            nums.AddLast(2);
            nums.AddLast(3);
            nums.AddFirst(3);
            nums.RemoveLast();

            Console.WriteLine(String.Join(Environment.NewLine, nums.ToArray()));
        }
    }
}
