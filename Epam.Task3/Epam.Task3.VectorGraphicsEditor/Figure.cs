// <copyright file="Figure.cs" company="Epam">
//     Copyright Epam. All rights reserved 
// </copyright>

namespace Epam.Task3.VectorGraphicsEditor
{
    /// <summary>
    ///  This abstract class describes a Figure.
    /// </summary>
    public abstract class Figure
    {
        /// <summary>
        /// Gets or sets the first point of the figure.
        /// </summary>
        public Point First { get; set; }

        /// <summary>
        /// Gets or sets the Second point of the figure.
        /// </summary>
        public Point Second { get; set; }

        /// <summary>
        /// abstract method to display Figure
        /// </summary>
        /// <returns>Info about figure</returns>
        public abstract string ToDisplay();
    }
}
