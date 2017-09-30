using System;

namespace OrderedStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stackList = new Stack();
            stackList.SortedPush(3);
            stackList.SortedPush(2);
            stackList.SortedPush(4);
            stackList.SortedPush(6);
            stackList.SortedPush(8);
            stackList.SortedPush(7);
            stackList.Pop();
            stackList.View();
            Console.Read();
        }
    }
}
