// <copyright file="Circle.cs" company="Epam">
//     Copyright Epam. All rights reserved 
// </copyright>

namespace Epam.Task3.VectorGraphicsEditor
{
    /// <summary>  
    ///  This class describes a Circle.
    /// </summary>  
    public class Circle : Figure
    {
        /// <summary>
        /// Initializes a new instance of the Circle class.
        /// </summary>
        /// <param name="center">center point</param>
        /// <param name="point">circle's point</param>
        public Circle(Point center, Point point)
        {
            this.First = center;
            this.Second = point;
        }

        /// <summary>
        /// abstract method to display Circle
        /// </summary>
        /// <returns>Info about figure</returns>
        public override string ToDisplay()
        {
            return $"Circle coordinaties is ({First.X}, {First.Y}), ({Second.X}, {Second.Y})";
        }
    }
}
