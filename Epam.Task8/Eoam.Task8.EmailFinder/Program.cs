// <copyright file="Program.cs" company="Epam">
//     Copyright Epam. All rights reserved 
// </copyright>

namespace Eoam.Task8.EmailFinder
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
            Regex regex = new Regex(@"^[A-Za-z0-9]+[\-\.\w]*[A-Za-z0-9]\@([A-Za-z0-9]+[\-A-Za-z0-9]*[A-Za-z0-9]\.)+[A-Za-z]{2,6}$");
            Console.Write("Enter a text: ");
            string[] text = Console.ReadLine().Split(' ', '\t', '\r', '\n', ',');
            Console.WriteLine("Found email addresses:");
            foreach (var item in text)
            {
                if (regex.IsMatch(item))
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
