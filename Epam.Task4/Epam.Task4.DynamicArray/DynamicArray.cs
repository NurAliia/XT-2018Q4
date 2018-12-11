// <copyright file="DynamicArray.cs" company="Epam">
//     Copyright Epam. All rights reserved 
// </copyright>

namespace Epam.Task4.DynamicArray
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Creates a new DynamicArray type <typeparamref name="T"/>
    /// </summary>
    /// <typeparam name="T">The element type of the array</typeparam>
    public class DynamicArray<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, ICloneable
    {
        /// <summary>
        /// Declare variable array
        /// </summary>
        private T[] array;

        /// <summary>
        /// Declare variable index
        /// </summary>
        private int index = -1;

        /// <summary>
        /// Initializes a new instance of the <see cref="DynamicArray{T}"/> class.
        /// </summary>
        public DynamicArray()
        {
            this.array = new T[8];
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DynamicArray{T}"/> class.
        /// </summary>
        /// <param name="capacity">Capacity new Cycled Dynamic Array</param>
        public DynamicArray(int capacity)
        {
            this.array = new T[capacity];
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DynamicArray{T}"/> class.
        /// </summary>
        /// <param name="collection">base collection</param>
        public DynamicArray(IEnumerable<T> collection)
        {
            int collectionCount = collection.Count();
            this.array = new T[collectionCount];
            for (var i = 0; i < collectionCount; i++)
            {
                this.array[i] = collection.ElementAt(i);
            }

            this.Length = collectionCount;
        }

        /// <summary>
        /// Gets or sets Array of the Dynamic array.
        /// </summary>
        public T[] Array
        {
            get
            {
                return this.array;
            }

            set
            {
                this.array = value;
            }
        }

        /// <summary>
        /// Gets or sets Capacity of the Dynamic array.
        /// </summary>
        public int Capacity
        {
            get
            {
                return this.array.Length;
            }

            set
            {
               System.Array.Resize(ref this.array, value);
            }
        }

        /// <summary>
        /// Gets or sets Length of the Dynamic array.
        /// </summary>
        public int Length { get; protected set; }

        /// <summary>
        /// Gets Current of the Dynamic Array for implementation IEnumerator.
        /// </summary>
        public T Current { get; private set; }

        /// <summary>
        /// Gets Current of the Dynamic Array for implementation IEnumerator.
        /// </summary>
        object IEnumerator.Current
        {
            get { return this.Current; }
        }

        /// <summary>
        /// Indexer of the dynamic array
        /// </summary>
        /// <param name="i">index of the object</param>
        /// <returns>object in current index</returns>
        public T this [int i]
        {
            get
            {
                if (i < 0)
                {
                    i = this.array.Length + i;
                }

                this.ThrowIfInvalid(i);
                return this.array[i];
            }

            set
            {
                if (i < 0)
                {
                    i = this.array.Length + i;
                }

                this.ThrowIfInvalid(i);
                this.array[i] = value;
            }
        }

        /// <summary>
        /// The method Clone for implementation interface
        /// </summary>
        /// <returns>Info about user string</returns>
        public object Clone()
        {
            return new DynamicArray<T> { array = this.array, Length = this.Length };
        }

        /// <summary>
        /// The method To Array 
        /// </summary>
        /// <returns>Convert Dynamic array to array</returns>
        public T[] ToArray()
        {
            T[] mas = new T[Length];
            for (int i = 0; i < Length; i++)
            {
                mas[i] = array[i];
            }
            return mas;
        }

        /// <summary>
        /// The method add
        /// </summary>
        /// <param name="x">new object</param>
        public void Add(T x)
        {
            this.Resize(1);
            this.array[this.Length] = x;
            this.Length++;
        }

        /// <summary>
        /// The method addRange
        /// </summary>
        /// <param name="collection">base collection</param>
        public void AddRange(IEnumerable<T> collection)
        {
            int i = this.Length;
            this.Resize(collection.Count());
            foreach (var item in collection)
            {
                this.array[i] = item;
                i++;
            }
        }

        /// <summary>
        /// The method insertFirst
        /// </summary>
        /// <param name="x">new objects</param>
        public void InsertFirst(T x) => this.InsertAt(0, x);

        /// <summary>
        /// The method insertLast
        /// </summary>
        /// <param name="x">new objects</param>
        public void InsertLast(T x) => this.InsertAt(this.Length, x);

        /// <summary>
        /// The method insert
        /// </summary>
        /// <param name="index">index of a new object</param>
        /// <param name="x">new objects</param>
        /// <returns>Success or no</returns>
        public bool Insert(int index, T x) => this.InsertAt(index, x);

        /// <summary>
        /// The method removeFirst
        /// </summary>
        /// <returns>success or no</returns>
        public bool RemoveFirst() => this.RemoveAt(0);

        /// <summary>
        /// The method insertLast
        /// </summary>
        /// <returns>success or no</returns>
        public bool RemoveLast() => this.RemoveAt(this.Length - 1);

        /// <summary>
        /// The method remove
        /// </summary>
        /// <param name="x">new objects</param>
        /// <returns>success or no</returns>
        public bool Remove(T x) => this.RemoveAt(this.IndexOf(x));

        /// <summary>
        /// The method GetEnumerator
        /// </summary>
        /// <returns>new Enumerator </returns>
        public IEnumerator<T> GetEnumerator()
        {
            int i = 0;
            foreach (T t in this.array)
            {
                i++;
                if (i > Length)
                {
                    break;
                }
                yield return t;
            }
        }

        /// <summary>
        /// The method GetEnumerator
        /// </summary>
        /// <returns>new Enumerator </returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        /// <summary>
        /// The method Dispose IEnumerator
        /// </summary>
        public void Dispose()
        {
            Console.WriteLine("Dispose");
        }

        /// <summary>
        /// The method Dispose IEnumerator
        /// </summary>
        /// <returns>Success or no</returns>
        public bool MoveNext()
        {
            if (this.Length == 0)
            {
                return false;
            }

            this.index = this.array.Length > this.index + 1 ? this.index + 1 : 0;
            this.Current = this.array[this.index];
            return true;
        }

        /// <summary>
        /// The method Reset IEnumerator
        /// </summary>
        public void Reset()
        {
            this.index = 0;
        }

        /// <summary>
        /// The method removeAt
        /// </summary>
        /// <param name="index">Index of the object into array</param>
        /// <returns>Exists or no</returns>
        private bool RemoveAt(int index)
        {
            if (index == -1)
            {
                return false;
            }

            for (var i = index; i < this.Length - 1; i++)
            {
                this.array[i] = this.array[i + 1];
            }

            this.array[this.Length - 1] = default(T);
            this.Length--;
            return true;
        }

        /// <summary>
        /// The method resize
        /// </summary>
        /// <param name="size">Count of new objects</param>
        private void Resize(int size)
        {
            if (size == 1)
            {
                if (this.array.Length < this.Length + size)
                {
                    System.Array.Resize(ref this.array, this.array.Length * 2);
                }
            }
            else
            {
                int r = (int)Math.Ceiling((double)this.Length / this.array.Length);
                if (this.array.Length < this.Length)
                {
                    System.Array.Resize(ref this.array, this.Length * r);
                }
            }
        }

        /// <summary>
        /// The method indexOf
        /// </summary>
        /// <param name="x">Current object</param>
        /// <returns>index of the object into array</returns>
        private int IndexOf(T x)
        {
            int i = 0;
            while ((i < this.Length) && (!this.array[i].Equals(x)))
            {
                i++;
            }

            if (i == this.Length)
            {
                return -1;
            }

            return i;
        }

        /// <summary>
        /// Check current index 
        /// </summary>
        /// <param name="index">index of the object</param>
        private void ThrowIfInvalid(int index)
        {
            if ((index < 0) || (index > this.Length))
            {
                throw new ArgumentOutOfRangeException(nameof(index));
            }
        }

        /// <summary>
        /// The method insertAt
        /// </summary>
        /// <param name="index">Index of new objects</param>
        /// <param name="x">new object</param>
        /// <returns>Success or no</returns>
        private bool InsertAt(int index, T x)
        {
            this.ThrowIfInvalid(index);
            this.Resize(1);
            for (var i = this.Length - 1; i > index; i--)
            {
                this.array[i] = this.array[i - 1];
            }

            this.array[index] = x;
            return true;
        }
    }
}
