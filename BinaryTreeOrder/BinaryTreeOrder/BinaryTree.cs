using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTreeOrder
{
    class BinaryTree
    {
        public Node Root;

        public BinaryTree() => Root = new Node(4);

        public void InOrderTraverse(Node Current)
        {
            if (Current != null)
            {
                InOrderTraverse(Current.Left);
                Console.WriteLine(Current.Data);
                InOrderTraverse(Current.Right);

            }
        }

        public void PostOrderTraverse(Node Current)
        {
            if(Current != null)
            {
            PostOrderTraverse(Current.Left);
            PostOrderTraverse(Current.Right);
            Console.WriteLine(Current.Data);

            }
        }
        public void PreOrderTraversal(Node Current)
        {
            if (Current != null)
            {
                Console.WriteLine(Current.Data);
                PreOrderTraversal(Current.Left);
                PreOrderTraversal(Current.Right);

            }
        }
        public void BreadthTraversal(Node Current)
        {
            Queue<Node> NodeQueue = new Queue<Node>();
            if(Current == null)
            {
                return;
            }
            NodeQueue.Enqueue(Current);
            while (NodeQueue.Count > 0)
            {
                Node n = NodeQueue.Dequeue();
                if(n.Left != null)
                {
                    NodeQueue.Enqueue(n.Left);
                }
                if(n.Right != null)
                {
                    NodeQueue.Enqueue(n.Right);
                }
                Console.WriteLine(n.Data);
            }
            
        }

        public class Node
        {
            public object Data;
            public Node Left { get; set; }
            public Node Right { get; set; }
            public Node Current { get; set; }

            public Node(object data)
            {
                Data = data;
                Left = null;
                Right = null;

            }
        }
    }
}
