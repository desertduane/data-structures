using System;
using System.Collections.Generic;
using System.Text;

namespace TowersOfHanoi
{
     class TowersOfHanoi
    {
        int count = 0;
        public void MoveTower(int discs, int start, int aux, int end)
        {
            count++;
            if(discs == 1)
            {
                Console.WriteLine(start + " -> " + end);
            }
            if (discs > 1)
            {
                
                MoveTower(discs - 1, start, end, aux);
                Console.WriteLine(start + " -> " + end);
                MoveTower(discs - 1, aux, start, end);
               
            }
        }
        public void Count()
        {
            Console.WriteLine(count);
        }
    }
}
