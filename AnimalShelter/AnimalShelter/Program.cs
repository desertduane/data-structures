using System;
using System.Collections;

namespace AnimalShelter
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue animals = new Queue();
            animals.Enqueue("cat");
            animals.Enqueue("cat");
            animals.Enqueue("dog");
            animals.Enqueue("cat");
            animals.Enqueue("cat");
            animals.Enqueue("dog");

            //GetPet(animals);
            Console.WriteLine();

            Console.WriteLine("would you like to adopt a cat or a dog?");
            string choice = Console.ReadLine();
            GetSpecificPet(animals, choice.ToLower());

            Console.Read();
        }
        public static void GetPet(Queue animals)
        {
            //gives the very first pet in the Queue
            Console.WriteLine(animals.Dequeue());

        }

        public static void GetSpecificPet(Queue animals, string type)
        {
            //if the first pet = the pet requested it gives it 
            if (animals.Peek().ToString().Contains(type))
            {
               
                animals.Dequeue();
            }
            //if you ask for an animal of a type not at the shelter it says cats and dogs only
            if(type != "cat" || type != "dog")
            {
                Console.WriteLine("We only shelter dogs and cats");
            }
            else
            {
                //adds animals to the unwanted queue until a match is found
                Queue unwanted = new Queue();
                while (!animals.Peek().ToString().Contains(type))
                {
                    unwanted.Enqueue(animals.Dequeue());
                }
                
            Console.WriteLine("Here is your new pet " + animals.Dequeue());
            }

            

        }
    }
}
