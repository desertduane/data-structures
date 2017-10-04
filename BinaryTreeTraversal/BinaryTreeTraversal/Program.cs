using System;

namespace BinaryTreeTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree myTree = new BinaryTree();
            myTree.Root.Left = new Node(1);
            myTree.Root.Right = new Node(2);
            myTree.Root.Left.Left = new Node(3);
            myTree.Root.Left.Right = new Node(4);
            myTree.Root.Right.Left = new Node(5);
            myTree.Root.Right.Right = new Node(6);

            myTree.GetChildren(myTree.Root);

           
            Console.Read();
        }
    }
}
