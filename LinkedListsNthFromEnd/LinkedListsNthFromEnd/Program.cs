﻿using System;

namespace LinkedListsNthFromEnd
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
            duanesDopeList.PrintList();
            Console.WriteLine();
            duanesDopeList.PrintMiddle();

            duanesDopeList.PrintNthFromEnd(3);

            Console.Read();
        }
    }
}
