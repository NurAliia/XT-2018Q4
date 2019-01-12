// <copyright file="Program.cs" company="Epam">
//     Copyright Epam. All rights reserved 
// </copyright>

namespace Epam.Task8.NumberValidator
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
            Console.Write("Enter a number: ");
            string str = Console.ReadLine();
            Regex real = new Regex(@"^[-+\d]\d*$|^[-+\d]?\d*.\d+$");
            Regex realScientific = new Regex(@"^[-+]?\d*.\d+[eE][\+\-]?\d+$");
            if (real.IsMatch(str))
            {
                Console.WriteLine("This number is in normal notation");
            }
            else if (realScientific.IsMatch(str))
            {
                Console.WriteLine("This number is in scientific notation");
            }
            else
            {
                Console.WriteLine("Incorrect number");
            }
        }
    }
}
