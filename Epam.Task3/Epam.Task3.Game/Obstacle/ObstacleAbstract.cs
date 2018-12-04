// <copyright file="ObstacleAbstract.cs" company="Epam">
//     Copyright Epam. All rights reserved 
// </copyright>

namespace Epam.Task3.Game.Obstacle
{
    /// <summary>  
    ///  This class describes a ObstacleAbstract.
    /// </summary>  
    public abstract class ObstacleAbstract : GameObject, IGameLevel
    {
        /// <summary>
        /// Initializes a new instance of the ObstacleAbstract class.
        /// </summary>
        /// <param name="point">point of the Object</param>
        public ObstacleAbstract(Point point) : base(point)
        {
        }

        /// <summary>
        /// Change level 
        /// </summary>
        /// <param name="player">Current player.</param>
        public abstract void LevelChange(Player player);

        /// <summary>
        /// Equals Coordinates 
        /// </summary>
        /// <param name="player">Current player.</param>
        public abstract void EqualsCoordinates(Player player);
    }
}
