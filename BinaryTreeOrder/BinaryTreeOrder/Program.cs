using System;
using static BinaryTreeOrder.BinaryTree;

namespace BinaryTreeOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree myTree = new BinaryTree();
            myTree.Root.Left = new Node(2);
            myTree.Root.Right = new Node(6);
            myTree.Root.Left.Left = new Node(1);
            myTree.Root.Left.Right = new Node(3);
            myTree.Root.Right.Left = new Node(5);
            myTree.Root.Right.Right = new Node(7);

            myTree.InOrderTraverse(myTree.Root);
            Console.WriteLine();
            myTree.PostOrderTraverse(myTree.Root);
            Console.WriteLine();
            myTree.PreOrderTraversal(myTree.Root);
            Console.WriteLine();
            myTree.BreadthTraversal(myTree.Root);


            Console.Read();
        }
    }
}
