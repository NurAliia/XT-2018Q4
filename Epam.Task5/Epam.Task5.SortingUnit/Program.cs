// <copyright file="Program.cs" company="Epam">
//     Copyright Epam. All rights reserved 
// </copyright>

namespace Epam.Task5.SortingUnit
{
    using System;
    using System.Threading;

    /// <summary>
    ///  This class performs a main function.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Auto Reset Event
        /// </summary>
        private static AutoResetEvent sync = new AutoResetEvent(false);

        /// <summary>
        /// Create array and sort it in the second thread
        /// </summary>
        public static void Main()
        {
            string[] array = new string[] { "Hi", "hi", "a", "hello", "bye" };
            Func<string, string, int> compareString = CustomSortDemo.Program.CompareByLengthThenByAlphabet;
            SortingUnit<string> sortingUnit = new SortingUnit<string>(array, compareString);

            sortingUnit.SortingFinished += MethodSort;

            sortingUnit.CreateThreadForSorting();
            sync.WaitOne(); ////Waiting Event
            array = sortingUnit.Arr;
            Console.WriteLine("Main Thread");
            CustomSort.Program.Print(array);
        }

        /// <summary>
        /// Handle event
        /// </summary>
        /// <param name="sender">Class of the publisher</param>
        /// <param name="e">Parameters of the event</param>
        public static void MethodSort(object sender, SortingEventArgs<string> e)
        {
            Console.WriteLine("Second thread");
            CustomSort.Program.Print(e.Array);
            sync.Set();
        }
    }
}
