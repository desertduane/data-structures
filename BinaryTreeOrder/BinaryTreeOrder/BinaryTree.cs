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
