using System;
using System.Collections.Generic;
using System.Text;

namespace PalindromeCheck
{
    class Queue 
    {
        public Node Head;
        public Node Tail;

        public Queue(string data)
        {
            //first node
            Head = new Node(data);
            Tail = Head;
            Console.WriteLine(Head.Data);
        }

        public void Enqueue(string data)
        {
            Node temp = Tail;
            Tail.Next = new Node(data);
            Tail = Tail.Next;
            Tail.Previous = temp;
            Console.WriteLine(Tail.Data);
        }

        public string Dequeue()
        {
            if (Head == Tail) {
                Tail = null;
            }
            Node temp = Head.Next;
            Head.Next = null;
            string value = Head.Data;
            Head = temp;
            return value;
        }

        public string IsPalindrome()
        {
            Node Start = Head;
            Node End = Tail;

            while (Start.Next != null && End.Previous != null)
            {
                if (Start.Data.Equals(End.Data) == true)
                {
                    Start = Start.Next;
                    End = End.Previous;
                }
                else
                {
                    return "Not a palindrome";
                }
            }
            return "Is a palindrome";
        }
    }
}
        
    


