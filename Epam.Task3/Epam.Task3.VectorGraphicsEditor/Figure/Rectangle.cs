// <copyright file="Rectangle.cs" company="Epam">
//     Copyright Epam. All rights reserved 
// </copyright>

namespace Epam.Task3.VectorGraphicsEditor
{
    using System;

    /// <summary>  
    ///  This class describes a Rectangle.
    /// </summary>  
    public class Rectangle : Figure
    {
        /// <summary>
        /// Initializes a new instance of the Rectangle class.
        /// </summary>
        /// <param name="first">first point</param>
        /// <param name="second">second point</param>
        public Rectangle(Point first, Point second)
        {
            this.First = first;
            this.Second = second;
        }

        /// <summary>
        /// abstract method to display Rectangle
        /// </summary>
        /// <returns>Info about figure</returns>
        public override string ToDisplay()
        {
            return $"Rectangle coordinaties is ({First.X}, {First.Y}), ({Second.X}, {Second.Y})";
        }
    }
}
