using System;

namespace StacksAndQues
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack StackList = new Stack();
            StackList.Push("One");
            StackList.Push("Two");
            StackList.Push("three");
            StackList.Push("four");
            StackList.Push("five");
            StackList.Push("six");
            StackList.Push("Seven");
            Console.WriteLine();

            Console.WriteLine("last in removed");
            StackList.Pop();
            Console.WriteLine();

            Queue QueueList = new Queue();
            QueueList.QueueUp("One");
            QueueList.QueueUp("two");
            QueueList.QueueUp("three");
            QueueList.QueueUp("four");
            QueueList.QueueUp("five");
            QueueList.QueueUp("six");
            Console.WriteLine();


            Console.WriteLine("First in removed");
            QueueList.UnQueue();
            Console.Read();
        }
    }
}
