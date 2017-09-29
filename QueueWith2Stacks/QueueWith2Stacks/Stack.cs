using System;
using System.Collections.Generic;
using System.Text;

namespace QueueWith2Stacks
{
    public class Stack
    {
        public Node Head;
        public Node Tail;

        public Stack(int data)
        {
            //first node of stack1 with data
            Head = new Node(data);
            Tail = Head;
            Console.WriteLine(Head.Data);
        }

        public Stack()
        {
            //creates stack2 with null
            Head = null;
            Tail = null;
        }

        public void Push(int data)
        {
            //Pushes node to a stack
            Node temp = Head;
            Head = new Node(data)
            {
                Next = temp
            };
            Console.WriteLine(Head.Data);
            
        }
        public Node Pop()
        {
            //pops a node from a stack
            if (Head == Tail)
            {
                Tail = null;
            }
            Node temp = Head.Next;
            Head.Next = null;
            Node value = Head;
            Head = temp;
            return value;
        }
    }
}
