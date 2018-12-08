// <copyright file="Point.cs" company="Epam">
//     Copyright Epam. All rights reserved 
// </copyright>

namespace Epam.Task3.VectorGraphicsEditor
{
    /// <summary>  
    ///  This class describes a point.
    /// </summary>  
    public class Point
    {
        /// <summary>
        /// Initializes a new instance of the Point class.
        /// </summary>
        public Point()
        {
            this.X = new RandomProject().GetNext;
            this.Y = new RandomProject().GetNext;
        }

        /// <summary>
        /// Initializes a new instance of the Point class.
        /// </summary>
        /// <param name="x">first coordinate of the point</param>
        /// <param name="y">second coordinate of the point</param>
        public Point(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        /// <summary>
        /// Gets or sets the X of the point.
        /// </summary>
        public double X { get; set; }

        /// <summary>
        /// Gets or sets the Y of the point.
        /// </summary>
        public double Y { get; set; }
    }
}
