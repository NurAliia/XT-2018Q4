// <copyright file="Program.cs" company="Epam">
//     Copyright Epam. All rights reserved 
// </copyright>
namespace Epam.Task4.Lost
{
    using System;
    using System.Collections.Generic;

    /// <summary>  
    ///  This class performs a main function.  
    /// </summary>  
    public class Program
    {
        /// <summary>
        /// Create list of people
        /// </summary>
        public static void Main()
        {
            var people = new List<string>();
            people.Add("Alina");
            people.Add("Kate");
            people.Add("Niko");
            people.Add("Oksana");
            people.Add("Ilya");
            people.Add("Lena");
            people.Add("Ivan");
            int i = 1;
            while (people.Count != 1)
            {
                for (; i < people.Count; i++)
                {
                    Console.WriteLine(people[i]);
                    people.Remove(people[i]);
                }

                if (i > people.Count)
                {
                    i = 1;
                }
                else
                {
                    i = 0;
                }
            }

            Console.WriteLine();
            Console.WriteLine($"Last {people[0]}");
        }
    }
}
