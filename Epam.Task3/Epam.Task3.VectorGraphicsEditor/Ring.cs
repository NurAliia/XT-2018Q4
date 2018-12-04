// <copyright file="Ring.cs" company="Epam">
//     Copyright Epam. All rights reserved 
// </copyright>

namespace Epam.Task3.VectorGraphicsEditor
{
    /// <summary>  
    ///  This class describes a Ring.
    /// </summary>  
    public class Ring : Figure
    {
        /// <summary>
        /// Declare variable first Circle
        /// </summary>
        private Circle firstCircle;

        /// <summary>
        /// Declare variable second Circle
        /// </summary>
        private Circle secondCircle;

        /// <summary>
        /// Initializes a new instance of the Ring class.
        /// </summary>
        /// <param name="center">center point</param>
        /// <param name="first">first point</param>
        /// <param name="second">second point</param>
        public Ring(Point center, Point first, Point second)
        {
            this.firstCircle = new Circle(center, first);
            this.secondCircle = new Circle(center, second);
        }

        /// <summary>
        /// abstract method to display Ring
        /// </summary>
        /// <returns>Info about figure</returns>
        public override string ToDisplay()
        {
            return $"Ring coordinaties is  ({firstCircle.First.X}, {firstCircle.First.Y}), ({firstCircle.Second.X}, {firstCircle.Second.Y}), ({secondCircle.Second.X}, {secondCircle.Second.Y})";
        }
    }
}
