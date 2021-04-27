using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    [MemoryDiagnoser]
    public static class Array
    {
        [Benchmark]
        public static void RevereseArray(int[] arr, int start, int end)
        {
            int temp;

            while (start < end)
            {
                temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;
                start++;
                end--;
            }
        }

        [Benchmark]
        public static int SimpleCountPairsWithDiffK(int[] arr, int n, int k)
        {
            int count = 0;

            // Pick all elements one by one 
            for (int i = 0; i < n; i++)
            {

                // See if there is a pair 
                // of this picked element 
                for (int j = i + 1; j < n; j++)
                    if (arr[i] - arr[j] == k ||
                          arr[j] - arr[i] == k)
                        count++;
            }

            return count;
        }

        static int ArrayBinarySearch(int[] arr, int low, int high, int x)
        {
            if (high >= low)
            {
                int mid = low + (high - low) / 2;
                if (x == arr[mid])
                    return mid;
                if (x > arr[mid])
                    return ArrayBinarySearch(arr, (mid + 1), high, x);
                else
                    return ArrayBinarySearch(arr, low, (mid - 1), x);
            }

            return -1;
        }

        //static int CountPairsWithDiffK(int[] arr, int n, int k)
        //{

        //    int count = 0, i;

        //    // Sort array elements 
        //    Array.Sort(arr);

        //    // code to remove duplicates from arr[]  

        //    // Pick a first element point 
        //    for (i = 0; i < n - 1; i++)
        //        if (ArrayBinarySearch(arr, i + 1, n - 1, arr[i] + k) != -1)
        //            count++;

        //    return count;
        //}

        [Benchmark]
        public static void PrintArray(int[] arr, int size)
        {
            for (int i = 0; i < size; i++)
                Console.Write(arr[i] + " ");

            Console.WriteLine();
        }

        public static void LeftRotate(int[] arr, int d, int n)
        {
            for (int i = 0; i < d; i++)
                LeftRotatebyOne(arr, n);
        }

        public static void LeftRotatebyOne(int[] arr, int n)
        {
            int i, temp = arr[0];
            for (i = 0; i < n - 1; i++)
                arr[i] = arr[i + 1];

            arr[i] = temp;
        }

        public static int LinearSearch(int[] arr, int n,int key)
        {
            for (int i = 0; i < n; i++)
                if (arr[i] == key)
                    return i;

            return -1;
        }

        public static int InsertSorted(int[] arr, int n,
                            int key,
                            int capacity)
        {

            // Cannot insert more elements 
            // if n is already more than  
            // or equal to capcity  
            if (n >= capacity)
                return n;

            arr[n] = key;
            return (n + 1);
        }
    }
}
