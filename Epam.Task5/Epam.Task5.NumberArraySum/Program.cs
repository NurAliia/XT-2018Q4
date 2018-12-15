// <copyright file="Program.cs" company="Epam">
//     Copyright Epam. All rights reserved 
// </copyright>

namespace Epam.Task5.NumberArraySum
{
    using System;
    using System.Linq;

    /// <summary>
    ///  This class performs a main function.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Test extensions. Create numeric arrays and counts the sum of items
        /// </summary>
        public static void Main()
        {
            try
            {
                int[] intergers = { 1, 2, 3 };
                double[] doubles = { 5.5 };
                Console.WriteLine($"int = {intergers.Sum1()}");
                Console.WriteLine($"double = {doubles.Sum1()}");
                double summary = intergers.Sum1() + doubles.Sum1();
                Console.WriteLine($"sum int[] + double[] = {summary}");
                float[] floats = { 1, 2.2F };
                Console.WriteLine($"float = {floats.Sum1()}");
                decimal[] decimals = { 100, 3.5M };
                Console.WriteLine($"decimal = {decimals.Sum1()}");
                long[] longs = { 231, 3 };
                Console.WriteLine($"long = {longs.Sum1()}");

                int?[] intergersNullable = { null, 4, 5 };
                Console.WriteLine($"nullable int = {intergersNullable.Sum()}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
