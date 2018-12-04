// <copyright file="IGameLevel.cs" company="Epam">
//     Copyright Epam. All rights reserved 
// </copyright>

namespace Epam.Task3.Game
{
    /// <summary>  
    ///  This interface describes a IGameLevel.
    /// </summary>  
    public interface IGameLevel
    {
        /// <summary>
        /// Abstract method info about object
        /// </summary>
        /// <param name="player">Current player</param>
        void LevelChange(Player player);
    }
}
