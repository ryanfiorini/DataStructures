using System;

namespace Learning
{
    class Program
    {
        static void Main(string[] args)
        {
            // REVERSE
            Console.WriteLine("Start Array:");
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            Array.PrintArray(arr, arr.Length);
            Array.RevereseArray(arr, 0, 5);
            Console.WriteLine("Reversed array:");
            Array.PrintArray(arr, 6);


            // MATCH PAIRS
            Console.WriteLine("");
            Console.WriteLine("Start Pairs Count:");
            int[] arr2 = { 1, 5, 3, 4, 2 };
            int k = 3;

            Array.PrintArray(arr2, arr2.Length);
            Console.WriteLine("K: " + k);

            Console.WriteLine("Count of pairs with given diff is:");
            Console.WriteLine(Array.SimpleCountPairsWithDiffK(arr2, arr2.Length, k));

            // LEFT ROTATION
            Console.WriteLine("");
            Console.WriteLine("Start Left Rotation:");
            int[] arr3 = { 1, 2, 3, 4, 5, 6, 7 };
            Array.PrintArray(arr3, 7);
            Array.LeftRotate(arr3, 2, 5);
            Array.PrintArray(arr3, 7);

            // LINEAR SEARCH
            Console.WriteLine("");
            Console.WriteLine("Start Left Rotation:");
            int[] arr4 = { 12, 34, 10, 6, 40 };
            int n = arr4.Length;
            Array.PrintArray(arr4, 5);

            // Using a last element as  
            // search element 
            int key = 40;
            Console.WriteLine("Search Item: " + key);
            int position = Array.LinearSearch(arr4, n, key);

            if (position == -1)
                Console.WriteLine("Element not found");
            else
                Console.WriteLine("Element Found at Position: "
                                    + (position + 1));

            // INSERT INTO SORTED ARRAY
            int[] arr5 = new int[20];
            arr5[0] = 12;
            arr5[1] = 16;
            arr5[2] = 20;
            arr5[3] = 40;
            arr5[4] = 50;
            arr5[5] = 70;
            int capacity = 20;
            int n5 = 6;
            int i, key5 = 26;

            Console.Write("Before Insertion: ");
            for (i = 0; i < n5; i++)
                Console.Write(arr5[i] + " ");
            Console.WriteLine();

            // Inserting key 
            n = Array.InsertSorted(arr5, n5, key5, capacity);

            Console.Write("After Insertion: ");
            for (i = 0; i < n; i++)
                Console.Write(arr5[i] + " ");
        }
    }
}
