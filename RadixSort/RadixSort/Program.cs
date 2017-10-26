using System;
using System.Collections.Generic;

namespace RadixSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 7, 5, 3, 6, 76, 45, 32 };
            int[] sortedArray = RadixSort(array);

            foreach(int n in sortedArray)
            {
                Console.Write(n + " ");
            }

            Console.Read();

          
        }
        static public int[] RadixSort(int[] array)
        {
            bool isFinished = false;
            int digitPosition = 0;

            List<Queue<int>> buckets = new List<Queue<int>>();
            InitializeBuckets(buckets);

            while (!isFinished)
            {
                isFinished = true;

                foreach (int value in array)
                {
                    int bucketNumber = GetBucketNumber(value, digitPosition);
                    if (bucketNumber > 0)
                    {
                        isFinished = false;
                    }

                    buckets[bucketNumber].Enqueue(value);
                }

                int i = 0;
                foreach (Queue<int> bucket in buckets)
                {
                    while (bucket.Count > 0)
                    {
                        array[i] = bucket.Dequeue();
                        i++;
                    }
                }

                digitPosition++;
            }

            return array;
        }

        static int GetBucketNumber(int value, int digitPosition)
        {
            int bucketNumber = (value / (int)Math.Pow(10, digitPosition)) % 10;
            return bucketNumber;
        }

        static void InitializeBuckets(List<Queue<int>> buckets)
        {
            for (int i = 0; i < 10; i++)
            {
                Queue<int> q = new Queue<int>();
                buckets.Add(q);
            }
        }
    }
}
