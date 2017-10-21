using System;
using static AnimalGuess.SearchTree;

namespace AnimalGuess
{
    class Program
    {
        static void Main(string[] args)
        {
            //root question
            SearchTree testTree = new SearchTree("Is it a Mammal?");
            //first left
            testTree.Root.Left = new Node("Does it Bark?")
            {
                Left = new Node("Dog"),
                Right = new Node("Cat")
            };
            //first right
            testTree.Root.Right = new Node("Can it fly?")
            {
                Left = new Node("Bird"),
                Right = new Node("Fish")
            };

            testTree.Question(testTree.Root);
            Console.Read();
        }
    }
}
