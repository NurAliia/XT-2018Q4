// <copyright file="SeachAPositiveNumbers.cs" company="Epam">
//     Copyright Epam. All rights reserved 
// </copyright>

namespace Epam.Task5.ISeekYou
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    ///  This class performs a main search different function.
    /// </summary>
    public class SeachAPositiveNumbers
    {
        /// <summary>  
        /// Regular search of a positive numbers in the collection <typeparamref name="T"/>
        /// </summary>
        /// <typeparam name="T">The type of element of the array</typeparam>
        /// <param name="collection">Current collection</param>
        /// <returns>New dynamic array with positive numbers</returns>
        public List<T> PositiveNumbers<T>(IEnumerable<T> collection) where T : IComparable<T>
        {
            List<T> newArray = new List<T>();
            foreach (T item in collection)
            {
                if (item.GetHashCode() > 0.GetHashCode())
                {
                    newArray.Add(item);
                }
            }

            return newArray;
        }

        /// <summary>  
        /// Search of a positive numbers in the collection with using delegate <typeparamref name="T"/>
        /// </summary>
        /// <typeparam name="T">The type of element of the array</typeparam>
        /// <param name="collection">Current collection</param>
        /// <param name="func">current condition search</param>
        /// <returns>New dynamic array with positive numbers</returns>
        public List<T> SearchThroughTheDelegate<T>(IEnumerable<T> collection, ConditionSeach<T> func) where T : IComparable<T>
        {
            List<T> newArray = new List<T>();
            foreach (T item in collection)
            {
                if (func(item))
                {
                    newArray.Add(item);
                }
            }

            return newArray;
        }
    }
}
