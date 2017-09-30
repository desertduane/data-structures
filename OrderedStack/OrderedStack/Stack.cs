using System;
using System.Collections.Generic;
using System.Text;

namespace OrderedStack
{
    class Stack
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
        public void SortedPush(int data)
        {
            List<int> tempList = new List<int>
            {
                data
            };

            while (Head != null)
            {
                tempList.Add(Pop().Data);
            }
            tempList.Sort();
            tempList.Reverse();

            foreach (int d in tempList)
            {
                Push(d);
            }
        }
        public void View()
        {
            Node runner = Head;
            string output = "Head -> ";
            while (runner.Next != null)
            {
                output += runner.Data + " <-> ";
                runner = runner.Next;
            }
            output += runner.Data + " -> null";
            Console.WriteLine(output);
        }
    }
}

