using System;

namespace PalindromeCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue QueueList = new Queue("b");
            QueueList.Enqueue("a");
            QueueList.Enqueue("a");
            QueueList.Enqueue("a");
            QueueList.Enqueue("a");
            QueueList.Enqueue("a");
            QueueList.Enqueue("b");

            Console.WriteLine(QueueList.IsPalindrome());
            Console.WriteLine();

            Queue QueueList2 = new Queue("z");
            QueueList2.Enqueue("a");
            QueueList2.Enqueue("a");
            QueueList2.Enqueue("c");
            QueueList2.Enqueue("a");
            QueueList2.Enqueue("a");
            QueueList2.Enqueue("c");
            Console.WriteLine(QueueList2.IsPalindrome());
            Console.Read();
        }
    }
}
