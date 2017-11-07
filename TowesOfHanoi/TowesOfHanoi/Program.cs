using System;

namespace TowersOfHanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            TowersOfHanoi tower = new TowersOfHanoi();

            //(number of discs, start pole, middle pole, end pole)
            tower.MoveTower(3, 1, 2, 3);
            Console.Write("number of moves = ");
            tower.Count();


            Console.Read();
        }
    }
}
