using System;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 4, 7, 2, 10, 7, 3, 6 };
            QuickSort(arr, 0, arr.Length - 1);

            foreach(int n in arr)
            {
                Console.WriteLine(n);
            }
                Console.Read();
        }

        static public void QuickSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                var pivot = Partition(arr, left, right);
               
                QuickSort(arr, left, pivot - 1);
                QuickSort(arr, pivot + 1, right);
            }
        }

        static public int Partition(int[] arr, int left, int right)
        {
            int temp;
            int p = arr[right];
            int i = left - 1;

            for(int j = left; j <= right -1; j++)
            {
                if(arr[j] <= p)
                {
                    i++;
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
            temp = arr[i + 1];
            arr[i + 1] = arr[right];
            arr[right] = temp;
            return i + 1;
        }
    }
}
