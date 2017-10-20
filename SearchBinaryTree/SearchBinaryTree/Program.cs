using BinarySearchTree;
using System;

namespace SearchBinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            SearchTree ArrTree = new SearchTree();
            int[] arr = new int[] { 4, 8, 15, 16, 23, 42 };
            int l = arr.Length;
            ArrTree.Root = ArrTree.SortedArr(arr, 0, l - 1);
            ArrTree.PreOrder(ArrTree.Root);
            Console.WriteLine();
            ArrTree.PostOrder(ArrTree.Root);

            //SearchTree testTree = new SearchTree();
            //testTree.Add(testTree.Root, 1);
            //testTree.Add(testTree.Root, 8);
            //testTree.Add(testTree.Root, 6);
            //testTree.Add(testTree.Root, 5);
            //testTree.Add(testTree.Root, 4);

            ////testTree.Root = testTree.Delete(testTree.Root, 8);

            //Console.WriteLine();



            //testTree.InOrder(testTree.Root);

            //Console.WriteLine();

            //testTree.PostOrder(testTree.Root);
            //Console.WriteLine();

            //testTree.PreOrder(testTree.Root);
            //Console.WriteLine();

            //testTree.Breadth(testTree.Root);
            //Console.WriteLine();

            //testTree.Min(testTree.Root);
            //testTree.Max(testTree.Root);
            

            Console.Read();
        }
    }
}
