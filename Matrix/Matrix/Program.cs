using System;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] ints = new int[,]
            {
                { 5, 1, 7, 3, 2 },
                { 3, 2, 8, 1, 5 },
                { 2, 7, 9, 2, 6 },
                { 1, 6, 0, 4, 9 },
                { 2, 5, 1, 7, 5 }

            };

            FindZero(ints);
            Console.Read();
        }

        static void FindZero(int[,] arr)
        {
            int X;
            int Y;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[i, j] == 0)
                    {
                        X = i;
                        Y = j;
                        AddZero(arr, X, Y);
                    }
                }
            }


        }
        static void AddZero(int[,] arr, int X, int Y)
        {

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (j == Y)
                    {
                        arr[i, j] = 0;
                    }

                    if (X == i)
                    {
                        arr[i, j] = 0;

                    }

                }
            }
        }
        
    }
}
