using System;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 4, 5, 2, 7, 8, 3 };
            InsertionSort(numbers);
            Console.Read();


        }
        static int[] InsertionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int n = i + 1; n > 0; n--)
                {
                    if (arr[n - 1] > arr[n])
                    {
                        int temp = arr[n - 1];
                        arr[n - 1] = arr[n];
                        arr[n] = temp;
                    }
                }
            }
            foreach(int n in arr)
            {
                Console.WriteLine(n);
            }
            return arr;
        }
    }
}
