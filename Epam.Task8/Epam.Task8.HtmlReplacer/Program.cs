// <copyright file="Program.cs" company="Epam">
//     Copyright Epam. All rights reserved 
// </copyright>

namespace Epam.Task8.HtmlReplacer
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
            Regex regex = new Regex(@"\<.+?\>");
            Console.Write("Enter a string: ");
            string read = Console.ReadLine();
            Console.WriteLine($"The result of the replacement: {regex.Replace(read,"_")}");
        }
    }
}
