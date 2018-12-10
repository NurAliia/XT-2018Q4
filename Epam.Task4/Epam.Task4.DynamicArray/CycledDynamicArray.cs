// <copyright file="CycledDynamicArray.cs" company="Epam">
//     Copyright Epam. All rights reserved 
// </copyright>

namespace Epam.Task4.DynamicArray
{
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Creates a new CycledDynamicArray type <typeparamref name="T"/>
    /// </summary>
    /// <typeparam name="T">The element type of the array</typeparam>
    public class CycledDynamicArray<T> : DynamicArray<T>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CycledDynamicArray{T}"/> class.
        /// </summary>
        public CycledDynamicArray()
        {
            this.Array = new T[8];
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CycledDynamicArray{T}"/> class.
        /// </summary>
        /// <param name="capacity">Capacity new Cycled Dynamic Array</param>
        public CycledDynamicArray(int capacity)
        {
            this.Array = new T[capacity];
        }

        /// <summary>
        ///Initializes a new instance of the <see cref="CycledDynamicArray{T}"/> class.
        /// </summary>
        /// <param name="collection">base collection</param>
        public CycledDynamicArray(IEnumerable<T> collection)
        {
            int collectionCount = collection.Count();
            this.Array = new T[collectionCount];
            for (var i = 0; i < collectionCount; i++)
            {
                this.Array[i] = collection.ElementAt(i);
            }

            this.Length = collectionCount;
        }

        /// <summary>
        /// New GetEnumerator()
        /// </summary>        
        /// <returns>Get Enumerator</returns>
        public new IEnumerator<T> GetEnumerator()
        {
            return this;
        }
    }
}
