// <copyright file="MonsterAbstract.cs" company="Epam">
//     Copyright Epam. All rights reserved 
// </copyright>

namespace Epam.Task3.Game.Monster
{
    /// <summary>  
    ///  This class describes a MonsterAbstract.
    /// </summary>  
    public abstract class MonsterAbstract : GameObject, IGameLevel
    {
        /// <summary>
        /// Initializes a new instance of the MonsterAbstract class.
        /// </summary>
        /// <param name="point">point of the Object</param>
        public MonsterAbstract(Point point) : base(point)
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
