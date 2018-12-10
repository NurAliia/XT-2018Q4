// <copyright file="ICloneable.cs" company="Epam">
//     Copyright Epam. All rights reserved 
// </copyright>

namespace Epam.Task4.DynamicArray
{
    /// <summary>
    /// Creates a new clone
    /// </summary>
    public interface ICloneable
    {
        /// <summary>
        /// The method Clone of the interface
        /// </summary>
        /// <returns>new cloned object</returns>
        object Clone();
    }
}
