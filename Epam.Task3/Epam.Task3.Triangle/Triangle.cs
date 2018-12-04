// <copyright file="Triangle.cs" company="Epam">
//     Copyright Epam. All rights reserved 
// </copyright>
namespace Epam.Task3.Triangle
{
    using System;

    /// <summary>  
    ///  This class describes a triangle.
    /// </summary>  
    public class Triangle
    {
        /// <summary>
        /// Declare variable of the side a
        /// </summary>
        private int a;

        /// <summary>
        /// Declare variable of the side b
        /// </summary>
        private int b;

        /// <summary>
        /// Declare variable of the side c
        /// </summary>
        private int c;

        /// <summary>
        /// Initializes a new instance of the Triangle class.
        /// </summary>        
        /// <param name="a">The first side of a triangle.</param>
        /// <param name="b">The second side of a triangle.</param>
        /// <param name="c">The third side of a triangle.</param>
        public Triangle(int a, int b, int c)
        {
            if (a >= b + c || b >= a + c || c >= a + b)
            {
                throw new Exception("Incorrect value");
            }
            else
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }
        }

        /// <summary>
        /// Gets or sets A of the triangle.
        /// </summary>
        public int A
        {
            get
            {
                return this.a;
            }

            set
            {
                if (value < this.b + this.c && value > 0)
                {
                    this.a = value;
                }
                else
                {
                    throw new Exception("Incorrect value");
                }
            }
        }

        /// <summary>
        /// Gets or sets B of the triangle.
        /// </summary>
        public int B
        {
            get
            {
                return this.b;
            }

            set
            {
                if (value < this.a + this.c && value > 0)
                {
                    this.b = value;
                }
                else
                {
                    throw new Exception("Incorrect value");
                }
            }
        }

        /// <summary>
        /// Gets or sets C of the triangle.
        /// </summary>
        public int C
        {
            get
            {
                return this.c;
            }

            set
            {
                if (value < this.a + this.b && value > 0)
                {
                    this.c = value;
                }
                else
                {
                    throw new Exception("Incorrect value");
                }
            }
        }

        /// <summary>
        /// Gets the Square of the round.
        /// </summary>
        public double Square
        {
            get
            {
                double p = this.Perimeter / 2;
                return Math.Sqrt(p * (p - this.a) * (p - this.b) * (p - this.c));
            }
        }

        /// <summary>
        /// Gets the Perimeter of the round.
        /// </summary>   
        public double Perimeter
        {
            get
            {
                return this.a + this.b + this.c;
            }
        }
    }
}
