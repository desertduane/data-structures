using System;

namespace LinkedListMiddle
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList duanesDopeList = new LinkedList();
            duanesDopeList.Add("ONE");
            duanesDopeList.Add("TWO");
            duanesDopeList.Add("THREE");
            duanesDopeList.Add("FOUR");
            duanesDopeList.Add("Five");
            duanesDopeList.Add("SIX");
            duanesDopeList.Add("SEVEN");
            duanesDopeList.Add("EIGHT");
            duanesDopeList.Add("NINE");
            duanesDopeList.printList();
            Console.WriteLine();
            duanesDopeList.printMiddle();
            Console.Read();
        }
    }
}
