using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    public class SearchTree
    {
        public Node Root { get; set; }

        public void Add(Node node, int data)
        {
            if (Root == null)
            {
                Root = new Node(data);
                Console.WriteLine(Root.Data);
                return;
            }
            if (node.Data == data)
            {
                return;
            }
            if (data < node.Data)
            {
                if (node.Left == null)
                {
                    node.Left = new Node(data);
                    Console.WriteLine(node.Left.Data);
                    return;
                }
                Add(node.Left, data);
            }
            if (data > node.Data)
            {
                if (node.Right == null)
                {
                    node.Right = new Node(data);
                    Console.WriteLine(node.Right.Data);
                    return;
                }
                Add(node.Right, data);
            }

        }
        public void InOrder(Node Current)
        {
            if (Current != null)
            {
                InOrder(Current.Left);
                Console.WriteLine(Current.Data);
                InOrder(Current.Right);
            }
        }

        public void PostOrder(Node Current)
        {
            if (Current != null)
            {
                InOrder(Current.Left);
                InOrder(Current.Right);
                Console.WriteLine(Current.Data);
            }
        }

        public void PreOrder(Node Current)
        {
            if (Current != null)
            {
                Console.WriteLine(Current.Data);
                InOrder(Current.Left);
                InOrder(Current.Right);
            }
        }

        public void Breadth(Node Current)
        {
            Queue<Node> q = new Queue<Node>();
            if (Current == null)
            {
                return;
            }
            q.Enqueue(Current);
            while (q.Count > 0)
            {
                Node n = q.Dequeue();
                if (n.Left != null)
                {
                    q.Enqueue(n.Left);
                }
                if (n.Right != null)
                {
                    q.Enqueue(n.Right);
                }
                Console.WriteLine(n.Data);
            }

        }

        public class Node
        {
            public int Data { get; set; }
            public Node Left { get; set; }
            public Node Right { get; set; }
            public Node Current { get; set; }

            public Node(int data)
            {
                Data = data;
                Left = null;
                Right = null;
            }
        }
    }
}
