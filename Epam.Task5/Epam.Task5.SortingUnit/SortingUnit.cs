// <copyright file="SortingUnit.cs" company="Epam">
//     Copyright Epam. All rights reserved 
// </copyright>

namespace Epam.Task5.SortingUnit
{
    using System;
    using System.Threading;

    /// <summary>
    /// Create sorting unit <typeparamref name="T"/>
    /// </summary>
    /// <typeparam name="T">The type of element of the array</typeparam>
    public class SortingUnit<T>
    {
        /// <summary>
        /// Delegate compare
        /// </summary>
        private Func<T, T, int> compare;

        /// <summary>
        /// Initializes a new instance of the <see cref="SortingUnit{T}"/> class.
        /// </summary>
        /// <param name="arr">Current array</param>
        /// <param name="compare">delegate compare</param>
        public SortingUnit(T[] arr, Func<T, T, int> compare)
        {
            this.Arr = arr;
            this.compare = compare;
        }

        /// <summary>
        /// Event finished sorting
        /// </summary>
        public event EventHandler<SortingEventArgs<T>> SortingFinished;

        /// <summary>
        /// Gets array 
        /// </summary>
        public T[] Arr { get; private set; }

        /// <summary>
        /// Sort array
        /// </summary>
        public void Sort()
        {
            this.Arr = CustomSort.Program.MergeSort(this.Arr, this.compare);
            this.SortingFinished?.Invoke(this, new SortingEventArgs<T>(this.Arr));
        }

        /// <summary>
        /// Create thread for sorting
        /// </summary>
        public void CreateThreadForSorting()
        {
            ThreadStart threadStart = new ThreadStart(this.Sort);
            Thread thread = new Thread(threadStart);
            thread.Start();
        }
    }
}
