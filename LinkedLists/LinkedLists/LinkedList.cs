using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedLists
{
    public class LinkedList
    {
        public Node head;

        public void Add(string data)
        {
            Node toAdd = new Node();
            toAdd.data = data;


            if (head == null)
            {
                toAdd.next = head;
                head = toAdd;
            }
            else
            {
                Node current = head;
                

                //Console.WriteLine(current.data);
                while (current.next != null)
                {
                    current = current.next;
                    //Console.WriteLine(current.data);
                }
                current.next = toAdd;

            }

        }
        public void printList() {

            if (head == null)
            {
                Console.WriteLine("list is empty"); 
            }
            else
            {
                Node current = head;
                Console.WriteLine(current.data);
                while (current.next != null)
                {
                    current = current.next;
                    Console.WriteLine(current.data);
                }

            }
        }

    }
}
