// <copyright file="Program.cs" company="Epam">
//     Copyright Epam. All rights reserved 
// </copyright>

namespace Epam.Task5.ISeekYou
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;

    /// <summary>
    /// Delegate refers to a condition search <typeparamref name="T"/>
    /// </summary>
    /// <typeparam name="T">The type of element of the array</typeparam>
    /// <param name="number">the number</param>
    /// <returns>Is it a positive number</returns>
    public delegate bool ConditionSeach<T>(T number);

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
        /// Create Dynamic Array and Compare 5 ways to work with them
        /// </summary>
        public static void Demo()
        {
            List<int> array = new List<int>();
            Random random = new Random();
            var sw = new Stopwatch();
            for (int i = 0; i < 10; i++)
            {
                array.Add(random.Next(-100, 100));
            }

            SeachAPositiveNumbers methods = new SeachAPositiveNumbers();
            var time = new HashSet<long>();
            for (int i = 0; i < 11; i++)
            {
                sw.Start();
                methods.PositiveNumbers(array);
                sw.Stop();
                time.Add(sw.ElapsedTicks);
            }

            Console.WriteLine($"Just method = {time.ElementAt(time.Count / 2)}");

            time.Clear();
            ConditionSeach<int> func = IsPositive;
            for (int i = 0; i < 11; i++)
            {
                sw.Start();
                methods.SearchThroughTheDelegate(array, func);
                sw.Stop();
                time.Add(sw.ElapsedTicks);
            }

            Console.WriteLine($"Seach with delegate = {time.ElementAt(time.Count / 2)}");

            time.Clear();
            ConditionSeach<int> funcAnon = delegate(int number)
            {
                if (number.GetHashCode() > 0.GetHashCode())
                {
                    return true;
                }

                return false;
            };

            for (int i = 0; i < 11; i++)
            {
                sw.Start();
                methods.SearchThroughTheDelegate(array, funcAnon);
                sw.Stop();
                time.Add(sw.ElapsedTicks);
            }

            Console.WriteLine($"Seach with anonymous delegate = {time.ElementAt(time.Count / 2)}");

            time.Clear();
            ConditionSeach<int> funcLambda = number => number.GetHashCode() > 0.GetHashCode();
            for (int i = 0; i < 11; i++)
            {
                sw.Start();
                methods.SearchThroughTheDelegate(array, funcLambda);
                sw.Stop();
                time.Add(sw.ElapsedTicks);
            }

            Console.WriteLine($"Seach with lambda delegate = {time.ElementAt(time.Count / 2)}");

            time.Clear();
            for (int i = 0; i < 11; i++)
            {
                sw.Start();
                array.Where(number => number.GetHashCode() > 0.GetHashCode());
                sw.Stop();
                time.Add(sw.ElapsedTicks);
            }

            int cout = time.Count();
            Console.WriteLine($"Seach with linq delegate = {time.ElementAt(time.Count / 2)}");
        }

        /// <summary>
        /// Condition search <typeparamref name="T"/>
        /// </summary>
        /// <typeparam name="T">The type of element  of the array</typeparam>
        /// <param name="number">the number</param>
        /// <returns>Is it a positive number</returns>
        public static bool IsPositive<T>(T number)
        {
            if (number.GetHashCode() > 0.GetHashCode())
            {
                return true;
            }

            return false;
        }
    }
}
