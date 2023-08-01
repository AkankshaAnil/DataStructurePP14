using DataStructurePP14;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, Let's Do The Practice Of DataStructure");

        LinkedList list = new LinkedList();
        list.AddNode(56);
        list.AddNode(30);
        list.AddNode(70);

        Console.WriteLine("Linked List Sequence: ");
        list.DisplayList();
    }
}