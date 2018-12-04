// <copyright file="Point.cs" company="Epam">
//     Copyright Epam. All rights reserved 
// </copyright>

namespace Epam.Task3.Game
{
    using System;

    /// <summary>  
    ///  This class describes a Point.
    /// </summary>  
    public class Point
    {
        /// <summary>
        /// Initializes a new instance of the Point class.
        /// </summary>
        /// <param name="x">The x of a point.</param>
        /// <param name="y">The y of a point.</param>
        public Point(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        /// <summary>
        /// Gets or sets X of the object.
        /// </summary>
        public double X { get; set; }

        /// <summary>
        /// Gets or sets Y of the object.
        /// </summary>
        public double Y { get; set; }

        /// <summary>
        /// override equals
        /// </summary>
        /// <param name="anotherPoint">point of another object</param>
        /// <returns>equals or no</returns>
        public override bool Equals(object anotherPoint)
        {
            var tempPoint = anotherPoint as Point;
            if (tempPoint == null)
            {
                return false;
            }

            return this.X == tempPoint.X && this.Y == tempPoint.Y;
        }

        /// <summary>
        /// override get hash code
        /// </summary>
        /// <returns>hash code point</returns>
        public override int GetHashCode()
        {
            return this.X.GetHashCode() ^ this.Y.GetHashCode();
        }
    }
}
