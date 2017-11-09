using System;
using System.Collections.Generic;
using System.Linq;

namespace Permutations
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "abcdefgh";
            char[] arr = str.ToCharArray();

            Permute(arr, 0, arr.Length - 1);

            Console.Read();
        }

        //pass a and b as references and makes a swap
        private static void Swap(ref char a, ref char b)
        {
            char temp = a;
            a = b;
            b = temp;
        }

        //takes parameters of string, starting index, ending index
        private static void Permute(char[] letters, int l, int r)
        {
            if (l == r)
            {
                Console.WriteLine(letters);
                return;
            }

            for (int i = l; i <= r; i++)
            {
                Swap(ref letters[l], ref letters[i]);
                Permute(letters, l + 1, r);

                // backtracking
                Swap(ref letters[l], ref letters[i]);
            }
        }
    }
}