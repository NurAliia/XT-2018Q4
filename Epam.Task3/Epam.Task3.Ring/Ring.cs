// <copyright file="Ring.cs" company="Epam">
//     Copyright Epam. All rights reserved 
// </copyright>

namespace Epam.Task3.Ring
{
    using Epam.Task3.Round21;

    /// <summary>  
    ///  This class describes a ring.
    /// </summary>  
    public class Ring
    {
        /// <summary>
        /// Initializes a new instance of the Ring class.
        /// </summary>
        public Ring()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Ring class.
        /// </summary>        
        /// <param name="internalR">The internal round</param>
        /// <param name="externalR">The external round</param>
        public Ring(Round internalR, Round externalR) 
        {
            this.ExternalR = externalR;
            this.InternalR = internalR;
        }

        /// <summary>
        /// Gets or sets the ExternalR of the ring.
        /// </summary>
        public Round ExternalR { get; set; }

        /// <summary>
        /// Gets or sets the InternalR of the ring.
        /// </summary>
        public Round InternalR { get; set; }

        /// <summary>
        /// Gets the Square of the ring.
        /// </summary>
        public double SquareRing
        {
            get
            {
                return this.ExternalR.Square - this.InternalR.Square;
            }
        }

        /// <summary>
        /// Gets the Total Length of the ring.
        /// </summary>
        public double TotalLength
        {
            get
            {
                return this.ExternalR.Circumference - this.InternalR.Circumference;
            }
        }
    }
}
