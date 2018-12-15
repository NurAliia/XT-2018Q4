// <copyright file="ExtensionArray.cs" company="Epam">
//     Copyright Epam. All rights reserved 
// </copyright>

namespace Epam.Task5.NumberArraySum
{
    using System;
    using System.Linq;

    /// <summary>
    ///  This class create a different extensions.
    /// </summary>
    public static class ExtensionArray
    {
        /// <summary>
        /// Sum of the integer collection
        /// </summary>
        /// <param name="source">Current collection</param>
        /// <returns>The sum of the elements</returns>
        public static int? Sum1(this System.Collections.Generic.IEnumerable<int?> source)
        {
            int? sum = 0;
            foreach (var item in source)
            {
                if (item != null)
                {
                    sum += item;
                }
            }

            return sum;
        }

        /// <summary>
        /// Sum of the integer collection
        /// </summary>
        /// <param name="source">Current collection</param>
        /// <returns>The sum of the elements</returns>
        public static int Sum1(this System.Collections.Generic.IEnumerable<int> source)
        {
            return source.Aggregate((x, y) => x + y);
        }

        /// <summary>
        /// Sum of the float? collection
        /// </summary>
        /// <param name="source">Current collection</param>
        /// <returns>The sum of the elements</returns>
        public static float? Sum1(this System.Collections.Generic.IEnumerable<float?> source)
        {
            float? sum = 0;
            foreach (var item in source)
            {
                if (item != null)
                {
                    sum += item;
                }
            }

            return sum;
        }

        /// <summary>
        /// Sum of the float collection
        /// </summary>
        /// <param name="source">Current collection</param>
        /// <returns>The sum of the elements</returns>
        public static float Sum1(this System.Collections.Generic.IEnumerable<float> source)
        {
            return source.Aggregate((x, y) => x + y);
        }

        /// <summary>
        /// Sum of the double? collection
        /// </summary>
        /// <param name="source">Current collection</param>
        /// <returns>The sum of the elements</returns>
        public static double? Sum1(this System.Collections.Generic.IEnumerable<double?> source)
        {
            double? sum = 0;
            foreach (var item in source)
            {
                if (item != null)
                {
                    sum += item;
                }
            }

            return sum;
        }

        /// <summary>
        /// Sum of the double collection
        /// </summary>
        /// <param name="source">Current collection</param>
        /// <returns>The sum of the elements</returns>
        public static double Sum1(this System.Collections.Generic.IEnumerable<double> source)
        {
            return source.Aggregate((x, y) => x + y);
        }

        /// <summary>
        /// Sum of the decimal? collection
        /// </summary>
        /// <param name="source">Current collection</param>
        /// <returns>The sum of the elements</returns>
        public static decimal? Sum1(this System.Collections.Generic.IEnumerable<decimal?> source)
        {
            decimal? sum = 0;
            foreach (var item in source)
            {
                if (item != null)
                {
                    sum += item;
                }
            }

            return sum;
        }

        /// <summary>
        /// Sum of the decimal collection
        /// </summary>
        /// <param name="source">Current collection</param>
        /// <returns>The sum of the elements</returns>
        public static decimal Sum1(this System.Collections.Generic.IEnumerable<decimal> source)
        {
            return source.Aggregate((x, y) => x + y);
        }

        /// <summary>
        /// Sum of the long? collection
        /// </summary>
        /// <param name="source">Current collection</param>
        /// <returns>The sum of the elements</returns>
        public static long? Sum1(this System.Collections.Generic.IEnumerable<long?> source)
        {
            long? sum = 0;
            foreach (var item in source)
            {
                if (item != null)
                {
                    sum += item;
                }
            }

            return sum;
        }

        /// <summary>
        /// Sum of the long collection
        /// </summary>
        /// <param name="source">Current collection</param>
        /// <returns>The sum of the elements</returns>
        public static long Sum1(this System.Collections.Generic.IEnumerable<long> source)
        {
            return source.Aggregate((x, y) => x + y);
        }
    }
}
