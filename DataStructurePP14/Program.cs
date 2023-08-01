using DataStructurePP14;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, Let's Do The Practice Of DataStructure");

        LinkedList linkedList = new LinkedList();
        linkedList.AddNode(56);
        linkedList.AddNode(30);
        linkedList.AddNode(70);

        Console.WriteLine("Linked List Sequence: ");
        linkedList.DisplayList();

        linkedList.Pop();

        Console.WriteLine("Linked List after pop: ");
        linkedList.DisplayList();
    }
}