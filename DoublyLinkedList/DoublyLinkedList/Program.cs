﻿using System;

namespace DoublyLinkedList
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
            duanesDopeList.Add("FIVE");
            duanesDopeList.Add("SIX");
            duanesDopeList.Add("SEVEN");
            duanesDopeList.Add("EIGHT");
            duanesDopeList.Add("NINE");
            duanesDopeList.printList();
            Console.WriteLine();
            duanesDopeList.printMiddle();

            duanesDopeList.printNthFromEnd(3);
            Console.WriteLine();


            duanesDopeList.Delete("ONE");
            Console.WriteLine();
            duanesDopeList.Delete("FIVE");


            Console.Read();
        }
    }
}
