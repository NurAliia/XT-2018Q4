// <copyright file="Program.cs" company="Epam">
//     Copyright Epam. All rights reserved 
// </copyright>
namespace Epam.Task3.Round21
{
    using System;

    /// <summary>  
    ///  This class performs a main function.  
    /// </summary>  
    public class Program
    {
        /// <summary>
        /// Create object Round
        /// </summary>
        public static void Main()
        {
            try
            {
                Round round = new Round(9, 3, 4);
                Console.WriteLine(round.Circumference);
                Console.WriteLine(round.Square);
                round.Radius = -1;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
