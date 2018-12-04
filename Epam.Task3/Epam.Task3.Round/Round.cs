// <copyright file="Round.cs" company="Epam">
//     Copyright Epam. All rights reserved 
// </copyright>
namespace Epam.Task3.Round21
{
    using System;

    /// <summary>  
    ///  This class describes a round.
    /// </summary>  
    public class Round
    {
        /// <summary>
        /// Declare variable name
        /// </summary>
        private int radius;

        /// <summary>
        /// Initializes a new instance of the Round class.
        /// </summary>
        public Round()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Round class.
        /// </summary>        
        /// <param name="x">The first a coordinate.</param>
        /// <param name="y">The second a coordinate.</param>
        /// <param name="radius">The radius of a round.</param>
        public Round(int x, int y, int radius)
        {
            this.X = x;
            this.Y = y;
            this.Radius = radius;
        }

        /// <summary>
        /// Gets or sets the radius of the round.
        /// </summary>
        public int Radius
        {
            get
            {
                return this.radius;
            }

            set
            {
                if (value >= 0)
                {
                    this.radius = value;
                }
                else
                {
                   throw new Exception("Radius should be a positive digit");
                }
            }
        }

        /// <summary>
        /// Gets or sets the x of the round.
        /// </summary>
        public int X { get; set; }

        /// <summary>
        /// Gets or sets the y of the round.
        /// </summary>       
        public int Y { get; set; }

        /// <summary>
        /// Gets the Circumference of the round.
        /// </summary>       
        public double Circumference
        {
            get
            {
                return 2 * Math.PI * this.Radius;
            }
        }

        /// <summary>
        /// Gets the Square of the round.
        /// </summary>       
        public double Square
        {
            get
            {
                return Math.PI * this.Radius * this.Radius;
            }
        }        
    }
}
