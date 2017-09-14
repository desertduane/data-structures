using System;

namespace nestedforloops
{
    class Program
    {
        static void Main(string[] args)
        {

            string catNip = "cat-nip  ";
            string mint = "mint  ";

            //multidimensional array that is 5x5
            string[,] garden = new string[5, 5];
            for(int row = 0; row < 5; row++)
            {
                for(int col = 0; col < 5; col++)
                {
                    if(row % 2 == 0)
                    {
                        garden[row, col] = catNip;
                        if((col > 0) && (garden[row, col - 1] == catNip))
                        {
                            garden[row, col] = mint;
                        }
                    }
                    else
                    {
                        garden[row, col] = mint;
                        if((col > 0) && (garden[row, col - 1] == mint))
                        {
                            garden[row, col] = catNip;
                        }
                    }
                    Console.Write(garden[row, col]);
                }
                Console.WriteLine("");
            }
            Console.Read();
        }
    }
}

