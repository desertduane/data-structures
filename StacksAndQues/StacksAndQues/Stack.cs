using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQues
{
    class Stack
    {
       public Node Tail;

       public void Push(object data)
        {
            Node newNode = new Node
            {
                Data = data
            };
            if(Tail == null)
            {
                //first node both head and tail
                Tail = newNode;
                Console.WriteLine(Tail.Data);
            }
            else
            {
                //makes each new node the new tail and writes it to console
                Tail.Next = newNode;
                newNode.Previous = Tail;
                Tail = newNode;
                Console.WriteLine(Tail.Data);
            }
        }
        public void Pop()
        {
            if(Tail == null)
            {
                Console.WriteLine("Stack is empty");
            }
            //removes tail node and sets previous node as new tail.
            Node removed = Tail;
            Tail = removed.Previous;
            Tail.Next = null;
            Console.WriteLine(Tail.Data);

        }
        
    }

}
