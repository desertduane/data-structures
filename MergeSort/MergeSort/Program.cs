using System;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 10, 3, 8, 7, 5, 12, 2, 1 };

            int length = 8;
           
            Sort(numbers, 0, length - 1);

            foreach(int i in numbers)
            {
                Console.WriteLine(i);
            }

            
            Console.Read();
        }

        static public void Sort(int[] numbers, int left, int right)
        {
            int mid = (right + left) / 2;
                
            if (right > left)
            {
                //recursivly breaks arry left half
                Sort(numbers, left, mid);
                //recursivly breaks array right half
                Sort(numbers, (mid + 1), right);
                Merge(numbers, left, (mid + 1), right);

            }
        }

        static public void Merge(int[] arr, int left, int mid, int right)
        {
           int[] temp = new int[arr.Length];

           int leftEnd = (mid - 1);
           int tempPos = left;
           int numElements = (right - left + 1);

            while (left <= leftEnd && mid <= right)
            {
                if (arr[left] <= arr[mid])
                {
                    temp[tempPos++] = arr[left++];
                }
                else
                {
                    temp[tempPos++] = arr[mid++];
                }
            }

            while (left <= leftEnd)
            {
                temp[tempPos++] = arr[left++];
            }

            while (mid <= right)
            {
                temp[tempPos++] = arr[mid++];
            }

            for (int i = 0; i < numElements; i++)
            {
                arr[right] = temp[right];
                right--;
            }
        }
    }
}
