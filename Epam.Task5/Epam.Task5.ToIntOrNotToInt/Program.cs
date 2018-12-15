// <copyright file="Program.cs" company="Epam">
//     Copyright Epam. All rights reserved 
// </copyright>

namespace Epam.Task5.ToIntOrNotToInt
{
    using System;
    using static Epam.Task5.ToIntOrNotToInt.ExtensionString;

    /// <summary>
    ///  This class performs a main function.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Create string and check it
        /// </summary>
        public static void Main()
        {
            string str = "+12.3e+3";
            Func<string, Automate, bool> func = ParseToUint;
            Console.WriteLine($"{str} is a positive number? - {str.UintParse(func)}");
        }
    }
}
