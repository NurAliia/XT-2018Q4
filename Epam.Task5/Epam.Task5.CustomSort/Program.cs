// <copyright file="Program.cs" company="Epam">
//     Copyright Epam. All rights reserved 
// </copyright>

namespace Epam.Task5.CustomSort
{
    using System;
    using System.Linq;

    /// <summary>
    ///  This class performs a main function.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Create array of number and sort it with using a delegate
        /// </summary>
        public static void Main()
        {
            try
            {
                Func<int, int, int> compare = CompareToLower;
                int[] numbers = { 5, 4, 3, 6, 7, 8 };
                numbers = MergeSort(numbers, compare);
                Print(numbers);

                compare = CompareToHigh;
                numbers = MergeSort(numbers, compare);
                Print(numbers);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Create method compare to high
        /// </summary>
        /// <param name="x">first parameter</param>
        /// <param name="y">second parameter</param>
        /// <returns>more or less first parameter</returns>
        public static int CompareToHigh(int x, int y)
        {
            if (x < y)
            {
                return 1;
            }

            return 0;
        }

        /// <summary>
        /// Create method compare to lower
        /// </summary>
        /// <param name="x">first parameter</param>
        /// <param name="y">second parameter</param>
        /// <returns>more or less first parameter</returns>
        public static int CompareToLower(int x, int y)
        {
            if (x > y)
            {
                return 1;
            }

            return 0;
        }

        /// <summary>
        /// Create method merge sort <typeparamref name="T"/>
        /// </summary>
        /// <typeparam name="T">The type of element of the array</typeparam>
        /// <param name="array">Current array</param>
        /// <param name="func">The condition sort</param>
        /// <returns>New collection</returns>
        public static T[] MergeSort<T>(T[] array, Func<T, T, int> func)
        {
            if (func == null)
            {
                throw new Exception("Delegate should be defined");
            }

            if (array.Length == 1)
            {
                return array;
            }

            int middle = array.Length / 2;
            return Merge(MergeSort(array.Take(middle).ToArray(), func), MergeSort(array.Skip(middle).ToArray(), func), func);
        }

        /// <summary>
        /// Create method merge <typeparamref name="T"/>
        /// </summary>
        /// <typeparam name="T">The type of element of the array</typeparam>
        /// <param name="arr1">The first part of the array</param>
        /// <param name="arr2">The second part of the array</param>
        /// <param name="func">The condition sort</param>
        /// <returns>New collection</returns>
        public static T[] Merge<T>(T[] arr1, T[] arr2, Func<T, T, int> func)
        {
            int ptr1 = 0, ptr2 = 0;
            T[] merged = new T[arr1.Length + arr2.Length];

            for (int i = 0; i < merged.Length; ++i)
            {
                if (ptr1 < arr1.Length && ptr2 < arr2.Length)
                {
                    merged[i] = func(arr1[ptr1], arr2[ptr2]) == 1 ? arr1[ptr1++] : arr2[ptr2++];
                }
                else
                {
                    merged[i] = ptr2 < arr2.Length ? arr2[ptr2++] : arr1[ptr1++];
                }
            }

            return merged;
        }

        /// <summary>
        /// Create method merge <typeparamref name="T"/>
        /// </summary>
        /// <typeparam name="T">The type of element of the array</typeparam>
        /// <param name="array">Current array</param>
        public static void Print<T>(T[] array)
        {
            foreach (var a in array)
            {
                Console.Write($"{a} ");
            }

            Console.WriteLine();
        }
    }
}
