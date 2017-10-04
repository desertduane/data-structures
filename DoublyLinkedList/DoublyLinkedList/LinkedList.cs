using System;
using System.Collections.Generic;
using System.Text;

namespace DoublyLinkedList
{
    class LinkedList
    {
        public Node head;
        int count;
        int midCount = 0;

        public LinkedList()
        {
            head = new Node(null);
        }

        public void Add(Object data)
        {
            Node toAdd = new Node(data);


            if (head == null)
            {
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
                toAdd.Previous = current;

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
                Node current = head.Next;
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
                Node current = head.Next;
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
                    if (listIndex > nth)
                    {
                        returnNode = returnNode.Next;
                        returnIndex++;
                    }
                }
                Console.WriteLine();
                Console.WriteLine(returnNode.Previous.Data);
                Console.WriteLine(returnNode.Data);


            }
        }

        public Node Delete(Object data)
        {
            Node returnNode = head;
            if (head == null)
            {
                Console.WriteLine("list is empty");
                return head;
            }
            else
            {
                Node current = head;

                if(current.Data == data)
                {
                    head = current.Next;
                    returnNode = current;
                    head.Previous = null;
                    return returnNode;
                }
                while(current.Next != null)
                {
                    if(current.Data == data)
                    {
                        current.Previous.Next = current.Next;
                        current.Next.Previous = current.Previous;
                        returnNode = current;
                    }
                    current = current.Next;
                }
                return returnNode;
                

            }
        }
    }
}

