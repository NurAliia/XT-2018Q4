// <copyright file="BonusAbstract.cs" company="Epam">
//     Copyright Epam. All rights reserved 
// </copyright>

namespace Epam.Task3.Game
{
    /// <summary>  
    ///  This class describes a BonusAbstract.
    /// </summary>  
    public abstract class BonusAbstract : GameObject, IGameLevel
    {
        /// <summary>
        /// Initializes a new instance of the BonusAbstract class.
        /// </summary>
        /// <param name="point">point of the Object</param>
        public BonusAbstract(Point point) : base(point)
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
