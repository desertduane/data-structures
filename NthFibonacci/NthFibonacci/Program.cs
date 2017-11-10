using System;

namespace NthFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 7;
            Console.WriteLine(FindFibonacci(n));
            Console.Read();
        }

        static int FindFibonacci(int n)
        {
            if(n <= 1)
            {
                return n;
            }
            return FindFibonacci(n - 1) + FindFibonacci(n - 2);
        }
    }
}
