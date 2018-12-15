// <copyright file="Program.cs" company="Epam">
//     Copyright Epam. All rights reserved 
// </copyright>

namespace Epam.Task5.CustomSortDemo
{
    using System;

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
                CreateArray(out string[] array);
                Func<string, string, int> compareString = CompareByLengthThenByAlphabet;
                array = CustomSort.Program.MergeSort(array, compareString);
                CustomSort.Program.Print(array);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Create string array
        /// </summary>
        /// <param name="array">empty array</param>
        public static void CreateArray(out string[] array)
        {
            Console.WriteLine("How many string do you want to enter?");
            bool flag = true;
            uint count = 0;
            while (flag)
            {
                if (uint.TryParse(Console.ReadLine(), out count) && count != 0)
                {
                    flag = false;
                }
                else
                {
                    Console.WriteLine("Please, enter a positive digit");
                }
            }

            array = new string[count];
            Console.WriteLine("Please, enter words separated by a enter");
            for (int i = 0; i < count;)
            {
                string word = Console.ReadLine();
                if (word == string.Empty)
                {
                    Console.WriteLine("Please, enter a word");
                }
                else
                {
                    array[i] = word;
                    i++;
                }
            }
        }

        /// <summary>
        /// Create method compare string by length
        /// </summary>
        /// <param name="first">first parameter</param>
        /// <param name="second">second parameter</param>
        /// <returns>more or less first parameter</returns>
        public static int CompareByLengthThenByAlphabet(string first, string second)
        {
            if (first.Length < second.Length)
            {
                return 1;
            }
            else if (first.Length == second.Length)
            {
                return CompareByAlphabet(first, second);
            }

            return -1;
        }

        /// <summary>
        /// Create method compare string by alphabet
        /// </summary>
        /// <param name="first">first parameter</param>
        /// <param name="second">second parameter</param>
        /// <returns>more or less first parameter</returns>
        public static int CompareByAlphabet(string first, string second)
        {
            for (int i = 0; i < first.Length; i++)
            {
                if (first[i] > second[i])
                {
                    return -1;
                }
            }

            return 1;
        }
    }
}
