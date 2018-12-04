// <copyright file="Program.cs" company="Epam">
//     Copyright Epam. All rights reserved 
// </copyright>

namespace Epam.Task3.Ring
{
    using System;
    using Epam.Task3.Round21;

    /// <summary>  
    ///  This class performs a main function.  
    /// </summary>  
    public class Program
    {
        /// <summary>
        /// Create object Ring
        /// </summary>
        public static void Main()
        {
            try
            {
                Ring ring = new Ring(new Round(3, 3, 4), new Round(3, 3, 7));
                Console.WriteLine(ring.SquareRing);
                Console.WriteLine(ring.TotalLength);
                ring.InternalR.Radius = -1;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
