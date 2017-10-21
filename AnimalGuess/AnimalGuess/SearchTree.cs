using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalGuess
{
    public class SearchTree
    {
        public Node Root { get; set; }

        public SearchTree(string data)
        {
            Root = new Node(data);
        }

        public void Question(Node Current)
        {
            if (Current.Left == null && Current.Right == null)
            {
                //base case
                Guess(Current);
            }
            else
            {
                //asks the question
                Console.WriteLine($"{ Current.Data}");
                //stores user answer 
                string answer = Console.ReadLine().ToLower();

                if (answer == "y" || answer == "yes")
                {
                    //goes left down the tree for a yes 
                    Question(Current.Left);
                }
                else
                {
                    //goes right for a no
                    Question(Current.Right);
                }
            }
        }
        public void Guess(Node node)
        {
            //makes an animal guess with the node data
            Console.WriteLine($"Is it a {node.Data}?");
            string answer = Console.ReadLine().ToLower();

            if (answer == "y" || answer == "yes")
            {
                Console.WriteLine("YAY");
            }
            else
            {
                Console.WriteLine("What animal did you have in mind?");
                //saves correct answer to newAnimal
                string newAnimal = Console.ReadLine();
                Console.WriteLine($"Give a Question to help me guess {node.Data} next time");
                //saves new question to newQuestion
                string newQuestion = Console.ReadLine();
                //adds the animal to the tree
                node.Right = new Node(newAnimal);
                //adds the question to be asked
                node.Left = new Node(node.Data);
                node.Data = newQuestion;

                //calls method to start the game over with new question and animal
                TryAgain();
            }
        }

        public void TryAgain()
        {
            Console.WriteLine("Play again?");
            string answer = Console.ReadLine().ToLower();
            if (answer == "y" || answer == "yes")
            {
                //starts game again with the first question 
                Question(Root);
            }
            else
            {
                Console.WriteLine("Ill get it next time");
                return;
            }
        }




        public class Node
        {
            public string Data { get; set; }
            public Node Left { get; set; }
            public Node Right { get; set; }
            public Node Current { get; set; }

            public Node(string data)
            {
                Data = data;
                Left = null;
                Right = null;
            }
        }
    }
}
