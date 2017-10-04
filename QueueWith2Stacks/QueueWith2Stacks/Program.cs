using System;

namespace QueueWith2Stacks
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue QueueList = new Queue(1);
            QueueList.Enqueue(2);
            QueueList.Enqueue(3);
            QueueList.Enqueue(4);
            QueueList.Enqueue(5);
            QueueList.Enqueue(6);
            Console.WriteLine();
            
            //Sends all nodes to stack2 Pops (1) then sends all nodes back to stack1
            
            Console.WriteLine($"{QueueList.Dequeue().Data} was dequeued");
            
            Console.WriteLine();

            Console.Read();
        }
    }
}
