// <copyright file="Program.cs" company="Epam">
//     Copyright Epam. All rights reserved 
// </copyright>
namespace Epam.Task8.DateExistance
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
            Regex regex = new Regex(@"\b(((0[1-9]|[12][0-9]|3[01])(\-)(0[13578]|1[02]))|((0[1-9]|[12][0-9]|3[0])(\-)(0[469]|11))|((0[1-9]|[12][0-9])(\-)(02)))(\-)\d{4}\b");
            Console.Write("Enter a string: ");
            string read = Console.ReadLine();
            if (regex.IsMatch(read))
            {
                Console.WriteLine($"The text \"{read}\" contains the date.");
            }
            else
            {
                Console.WriteLine($"The text \"{read}\" doesn't contain the date.");
            }
        }
    }
}
