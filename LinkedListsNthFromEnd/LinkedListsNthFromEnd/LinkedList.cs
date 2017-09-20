using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListsNthFromEnd
{
    class LinkedList
    {
        public Node head;
        int count;
        int midCount = 0;

        public void Add(string data)
        {
            Node toAdd = new Node(data);


            if (head == null)
            {
                toAdd.Next = head;
                head = toAdd;

            }
            else
            {
                Node current = head;
               
                while (current.Next != null)
                {
                    current = current.Next;
                    
                }
                current.Next = toAdd;

            }
            count++;
            if (count % 2 != 0 && count > 2)
            {
                midCount++;
            }

        }
        public void printList()
        {

            if (head == null)
            {
                Console.WriteLine("list is empty");
            }
            else
            {
                Node current = head;
                Console.WriteLine(current.Data);
                while (current.Next != null)
                {
                    current = current.Next;
                    Console.WriteLine(current.Data);
                }

            }
        }
        public void printMiddle()
        {
            int listIndex = 0;

            if (head == null)
            {
                Console.WriteLine("list is empty");
            }
            else
            {
                Node current = head;
                while (listIndex < midCount)
                {
                    current = current.Next;
                    listIndex++;
                }
                Console.WriteLine(current.Data);
                Console.WriteLine(listIndex);

            }
        }

        public void printNthFromEnd(int nth)
        {
            int listIndex = 0;
            int returnIndex = 0;

            if (head == null)
            {
                Console.WriteLine("list is empty");
            }
            else
            {
                Node current = head;
                Node returnNode = head;
                while (current.Next != null)
                {
                    current = current.Next;
                    listIndex++;
                    if(listIndex > nth)
                    {
                        returnNode = returnNode.Next;
                        returnIndex++;
                    }
                }
                Console.WriteLine();
                Console.WriteLine(returnNode.Data);
               

            }
        }
    }

}
