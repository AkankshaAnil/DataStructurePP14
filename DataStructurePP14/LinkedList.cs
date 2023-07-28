using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructurePP14
{
    public class LinkedList
    {
        internal Node head;
        internal void Add(int data)
        {
            Node node = new Node(data);
            if(this.head == null )
            {
                this.head = node;
            }
            else
            {
             Node temp = head;
                while( temp.next != null ) 
                {
                temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into LinkedList", node.data);
        }
        internal void Display()
        { 
        Node temp = this.head;
            if( temp == null )
            {
                Console.WriteLine("LinkedList is Empty");
                return;
            }
            while( temp != null )
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        
        }

    }
}
