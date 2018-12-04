// <copyright file="Program.cs" company="Epam">
//     Copyright Epam. All rights reserved 
// </copyright>
namespace Epam.Task3.Triangle
{
    using System;

    /// <summary>  
    ///  This class performs a main function.  
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Create object Triangle
        /// </summary>
        public static void Main()
        {
            try
            {
                Triangle t = new Triangle(3, 4, 2);
                Console.WriteLine(@"Perimeter = {0}", t.Perimeter);
                Console.WriteLine(@"Square = {0}", t.Square);
                t.C = 5;
                Console.WriteLine(@"Perimeter = {0}", t.Perimeter);
                Console.WriteLine(@"Square = {0}", t.Square);
                t.A = -3;  ////Exception
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
