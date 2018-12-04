// <copyright file="Field.cs" company="Epam">
//     Copyright Epam. All rights reserved 
// </copyright>

namespace Epam.Task3.Game
{
    using System;

    /// <summary>  
    ///  This class describes a Field.
    /// </summary>  
    public class Field
    {
        /// <summary>
        /// Declare variable Field
        /// </summary>
        private static Field instance;

        /// <summary>
        /// Declare variable width
        /// </summary>
        private int width;

        /// <summary>
        /// Declare variable height
        /// </summary>
        private int height;

        /// <summary>
        /// Initializes a new instance of the Field class.
        /// </summary>
        /// <param name="width">The width of a field.</param>
        /// <param name="height">The height of a field.</param>
        private Field(int width, int height)
        {
            this.Width = width;
            this.Height = height;
        }

        /// <summary>
        /// Gets or Sets width of the Field.
        /// </summary>
        public int Width
        {
            get
            {
                return this.width;
            }

            private set
            {
                if (value > 0)
                {
                    this.width = value;
                }
                else
                {
                    throw new ArgumentException("Incorrect width of field");
                }
            }
        }

        /// <summary>
        /// Gets or Sets height of the Field.
        /// </summary>
        public int Height
        {
            get
            {
                return this.height;
            }

            private set
            {
                if (value > 0)
                {
                    this.height = value;
                }
                else
                {
                    throw new ArgumentException("Incorrect height of field");
                }
            }
        }

        /// <summary>
        /// get instance Field
        /// </summary>
        /// <param name="width">The width of a field.</param>
        /// <param name="height">The height of a field.</param>
        /// <returns>exist field</returns>
        public static Field GetInstance(int width, int height)
        {
            if (instance == null)
            {
                instance = new Field(width, height);
            }

            return instance;
        }
    }
}
