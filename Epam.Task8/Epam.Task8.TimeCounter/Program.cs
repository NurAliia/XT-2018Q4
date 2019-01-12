// <copyright file="Program.cs" company="Epam">
//     Copyright Epam. All rights reserved 
// </copyright>

namespace Epam.Task8.TimeCounter
{
    using System;
    using System.Text.RegularExpressions;

    /// <summary>
    ///  This class performs a main function.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static void Main()
        {
            Console.Write("Enter the text: ");
            string str = Console.ReadLine();
            Regex time = new Regex(@"\b(([0-1]?[0-9]|[2][0-4])[\:]([0-5]?[0-9]|[6][0]))\b");
            Console.WriteLine($"Time in the text is present {time.Matches(str).Count} time.");
        }
    }
}
