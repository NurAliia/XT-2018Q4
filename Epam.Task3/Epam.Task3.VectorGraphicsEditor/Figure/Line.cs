// <copyright file="Line.cs" company="Epam">
//     Copyright Epam. All rights reserved 
// </copyright>

namespace Epam.Task3.VectorGraphicsEditor
{
    /// <summary>  
    ///  This class describes a Line.
    /// </summary>  
    public class Line : Figure
    {
        /// <summary>
        /// Initializes a new instance of the Line class.
        /// </summary>
        /// <param name="first">first point</param>
        /// <param name="second">second point</param>
        public Line(Point first, Point second)
        {
            this.First = first;
            this.Second = second;
        }

        /// <summary>
        /// abstract method to display Line
        /// </summary>
        /// <returns>Info about figure</returns>
        public override string ToDisplay()
        {
            return $"Line coordinaties is ({First.X}, {First.Y}), ({Second.X}, {Second.Y})";
        }
    }
}
