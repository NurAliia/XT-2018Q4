// <copyright file="SortingEventArgs.cs" company="Epam">
//     Copyright Epam. All rights reserved 
// </copyright>

namespace Epam.Task5.SortingUnit
{
    using System;

    /// <summary>
    /// Create event <typeparamref name="T"/>
    /// </summary>
    /// <typeparam name="T">The type of element of the array</typeparam>
    public class SortingEventArgs<T> : EventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SortingEventArgs{T}"/> class.
        /// </summary>
        /// <param name="array">Current array</param>
        public SortingEventArgs(T[] array)
        {
            if (array != null)
            {
                this.Array = array;
            }
            else
            {
                throw new Exception("Array can not be null");
            }
        }

        /// <summary>
        /// Gets array 
        /// </summary>
        public T[] Array { get; private set; }
    }
}
