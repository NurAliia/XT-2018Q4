// <copyright file="Program.cs" company="Epam">
//     Copyright Epam. All rights reserved 
// </copyright>

namespace Epam.Task4.DynamicArray
{
    using System;
    using System.Collections.Generic;

    /// <summary>  
    ///  This class performs a main function.
    /// </summary>  
    public class Program
    {
        /// <summary>
        /// Use Demo
        /// </summary>
        public static void Main()
        {
            Demo();
        }

        /// <summary>
        /// Create Dynamic Array and Cycled Dynamic Array
        /// </summary>
        public static void Demo()
        {
            try
            {
                List<int> l = new List<int>();
                l.Add(1);
                l.Add(2);
                l.Add(3);
                l.Add(40);
                DynamicArray<int> d = new DynamicArray<int>(l);
                d.Add(5);
                d.Add(6);
                d.Add(77);
                d.Add(80);
                d.Capacity = 10;
                Console.WriteLine($"Capacity = {d.Capacity}");
                Console.WriteLine($"Length = {d.Length}");
                d[7] = 9;
                Console.WriteLine("Negative index " + d[-8]);
                Console.WriteLine("Dynamic array:");
                foreach (var i in d)
                {
                    Console.WriteLine(i);
                }
                if (d.Remove(3))
                {
                    Console.WriteLine("Element was deleted");
                }
                DynamicArray<int> dc = (DynamicArray<int>)d.Clone();
                Console.WriteLine("Dynamic array clone:");
                Console.WriteLine($"Capacity = {dc.Capacity}");
                Console.WriteLine($"Length = {dc.Length}");
                foreach (var i in dc)
                {
                    Console.WriteLine(i);
                }

                Console.WriteLine("To array:");
                int[] massive = d.ToArray();
                Console.WriteLine($"Length = {massive.Length}");
                foreach (var i in massive)
                {
                    Console.WriteLine(i);
                }

                CycledDynamicArray<int> cd = new CycledDynamicArray<int>(d);
                Console.WriteLine($"Capacity = {cd.Capacity}");
                Console.WriteLine($"Length = {cd.Length}");
                foreach (var i in cd)
                {
                    Console.WriteLine(i);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
