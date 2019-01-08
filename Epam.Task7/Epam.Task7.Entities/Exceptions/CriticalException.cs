// <copyright file="CriticalException.cs" company="Epam">
//     Copyright Epam. All rights reserved 
// </copyright>

namespace Epam.Task7.Entities.Exceptions
{
    using System;

    /// <summary>  
    ///  This class describes a CriticalException.
    /// </summary>  
    public class CriticalException : Exception
    {
        /// <summary>
        ///  Initializes a new instance of the <see cref="CriticalException" /> class
        /// </summary>  
        public CriticalException()
        {
        }

        /// <summary>
        ///  Initializes a new instance of the <see cref="CriticalException" /> class
        /// </summary>  
        /// <param name="message">exception message</param>
        public CriticalException(string message) : base(message)
        {
        }

        /// <summary>
        ///  Initializes a new instance of the <see cref="CriticalException" /> class
        /// </summary>  
        /// <param name="message">exception message</param>
        /// <param name="innerException">inner exception</param>
        public CriticalException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
