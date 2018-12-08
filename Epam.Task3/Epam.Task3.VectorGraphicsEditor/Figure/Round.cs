// <copyright file="Round.cs" company="Epam">
//     Copyright Epam. All rights reserved 
// </copyright>

namespace Epam.Task3.VectorGraphicsEditor
{
    using System;

    /// <summary>  
    ///  This class describes a Round.
    /// </summary>  
    public class Round : Figure
    {
        /// <summary>
        /// Initializes a new instance of the Round class.
        /// </summary>
        /// <param name="first">first point</param>
        /// <param name="second">second point</param>
        public Round(Point first, Point second)
        {
            this.First = first;
            this.Second = second;
        }

        /// <summary>
        /// abstract method to display Round
        /// </summary>
        /// <returns>Info about figure</returns>
        public override string ToDisplay()
        {
            return $"Round coordinaties is ({First.X}, {First.Y}), ({Second.X}, {Second.Y})";
        }      
    }
}
