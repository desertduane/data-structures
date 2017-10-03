using System;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree myTree = new Tree();
            myTree.Root.Left = new Leaf(1);
            myTree.Root.Right = new Leaf(2);
            myTree.Root.Left.Left = new Leaf(3);
            myTree.Root.Left.Right = new Leaf(4);
            myTree.Root.Right.Left = new Leaf(5);
            myTree.Root.Right.Right = new Leaf(6);

            Console.WriteLine(myTree.Root.Right.Right.Data);
            Console.WriteLine(myTree.Root.Data);
            Console.Read();
        }
    }
}
