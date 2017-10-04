using System;
using System.Collections.Generic;
using System.Text;

namespace QueueWith2Stacks
{
    public class Queue
    {
        public Stack Stack1 { get; set; }
        public Stack Stack2 { get; set; }

        public Queue(int data)
        {
            //create instances of stack1 and stack2
            Stack1 = new Stack(data);
            Stack2 = new Stack();
        }
        public void Enqueue(int data)
        {
            //add nodes to stack1
            Stack1.Push(data);
        }
        public Node Dequeue()
        {
            //Pushes all nodes to stack2 Pops off the Head node then pushes
            //nodes back to stack1
            while(Stack1.Head != null)
            {
                Stack2.Push(Stack1.Pop().Data);
            }
            Console.WriteLine();
            Node temp = Stack2.Pop();
            while (Stack2.Head != null)
            {
                Stack1.Push(Stack2.Pop().Data);
            }
            Console.WriteLine();
            return temp;
        }
    }
}
