using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTreeTraversal
{
    class BinaryTree
    {
        public Node Root;

        public BinaryTree() => Root = new Node(null);

        public void GetChildren(Node Current)
        {
            if(Current != null || Current != null)
            {
            GetChildren(Current.Left); 
            GetChildren(Current.Right); 
            Console.WriteLine(Current.Data);

            }
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
