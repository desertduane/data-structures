using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQues
{
    class Queue
    {
        public Node Head;
        public Node Tail;

        public void QueueUp(object data)
        {
            Node newNode = new Node
            {
                Data = data
            };
            if (Head == null)
            {
                //sets first node which is the head and tail
                Head = newNode;
                Tail = Head;
                Console.WriteLine(Tail.Data);
            }
            else
            {
                //sets next to the new node and makes it the tail
                Tail.Next = newNode;
                Tail = newNode;
                Console.WriteLine(Tail.Data);
            }

        }
        public void UnQueue()
        {
            if (Head == null)
            {
                Console.WriteLine("Empt Queue");
            }
            //removes the first node in and sets new head
            Node remove = Head;
            Head = remove.Next;
            Console.WriteLine(Head.Data);
        }
    }
}
