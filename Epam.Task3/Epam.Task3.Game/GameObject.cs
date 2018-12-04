// <copyright file="GameObject.cs" company="Epam">
//     Copyright Epam. All rights reserved 
// </copyright>

namespace Epam.Task3.Game
{
    using System;

    /// <summary>  
    ///  This class describes a GameObject.
    /// </summary>  
    public abstract class GameObject
    {
        /// <summary>
        /// Declare variable point
        /// </summary>
        private Point point;

        /// <summary>
        /// Declare variable field
        /// </summary>
        private Field field = Field.GetInstance(100, 100);

        /// <summary>
        /// Initializes a new instance of the GameObject class.
        /// </summary>
        /// <param name="point">the point of the game object</param>
        public GameObject(Point point)
        {
            this.Point = point;
        }

        /// <summary>
        /// Gets or Sets width of the Point.
        /// </summary>
        public Point Point
        {
            get
            {
                return this.point;
            }

            private set
            {
                if (value.X <= this.field.Width && value.Y <= this.field.Height)
                {
                    this.point = new Point(value.X, value.Y);
                }
                else
                {
                    throw new ArgumentException("Incorrect game object coordinaties");
                }
            }
        }

        /// <summary>
        /// Abstract method info about object
        /// </summary>
        /// <returns>string info</returns>
        public abstract string InfoObject();

        /// <summary>
        /// Compare coordinates
        /// </summary>
        /// <param name="anotherObjectGame">another Object Game</param>
        /// <returns>equals or no</returns>
        public bool EqualsCoordinates(Point anotherObjectGame)
        {
            return this.point.Equals(anotherObjectGame);
        }
    }
}
