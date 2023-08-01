using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DataStructurePP14
{
        public class LinkedList
        {
            public Node Head;

            public LinkedList()
            {
                Head = null;
            }

            public void AddNode(int data)
            {
                Node newNode = new Node(data);

                if (Head == null)
                {
                    Head = newNode;
                }
                else
                {
                    Node current = Head;
                    while (current.Next != null)
                    {
                        current = current.Next;
                    }
                    current.Next = newNode;
                }
            }

            public void DisplayList()
            {
                Node current = Head;
                while (current != null)
                {
                    Console.Write(current.Data + "->");
                    current = current.Next;
                }
                Console.WriteLine("null");
            }
        }
    }
    

