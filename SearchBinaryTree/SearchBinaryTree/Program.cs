using BinarySearchTree;
using System;

namespace SearchBinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            SearchTree testTree = new SearchTree();
            testTree.Add(testTree.Root, 1);
            testTree.Add(testTree.Root, 8);
            testTree.Add(testTree.Root, 6);
            testTree.Add(testTree.Root, 5);
            testTree.Add(testTree.Root, 4);

            testTree.Root = testTree.Delete(testTree.Root, 8);

            Console.WriteLine();



            testTree.InOrder(testTree.Root);

            Console.WriteLine();

            testTree.PostOrder(testTree.Root);
            Console.WriteLine();

            testTree.PreOrder(testTree.Root);
            Console.WriteLine();

            testTree.Breadth(testTree.Root);
            Console.WriteLine();

            testTree.Min(testTree.Root);
            testTree.Max(testTree.Root);
            

            Console.Read();
        }
    }
}
