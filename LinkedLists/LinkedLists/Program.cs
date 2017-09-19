using System;

namespace LinkedLists
{
    class Program
    {
        static void Main(string[] args)
        {
           

            LinkedList duanesDopeList = new LinkedList();
            duanesDopeList.Add("My dope list");
            duanesDopeList.Add("My dope list?!!?");
            duanesDopeList.Add("adding to the list");
            duanesDopeList.Add("hello everyone");
            duanesDopeList.printList();
            Console.Read();
        }
    }
}
