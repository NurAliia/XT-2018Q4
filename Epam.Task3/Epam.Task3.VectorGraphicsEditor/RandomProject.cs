// <copyright file="RandomProject.cs" company="Epam">
//     Copyright Epam. All rights reserved 
// </copyright>

namespace Epam.Task3.VectorGraphicsEditor
{
    using System;

    /// <summary>  
    ///  This class describes a Random for coordinates.
    /// </summary>  
    public class RandomProject
    {
        /// <summary>
        /// Declare variable static random
        /// </summary>
        private static Random random = new Random();

        /// <summary>
        /// Gets the GetNext of the random coordinate.
        /// </summary>
        public int GetNext
        {
            get
            {
                return random.Next(-10, 10);
            }
        }
    }
}
