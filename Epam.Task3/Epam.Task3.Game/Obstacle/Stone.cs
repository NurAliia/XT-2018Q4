// <copyright file="Stone.cs" company="Epam">
//     Copyright Epam. All rights reserved 
// </copyright>

namespace Epam.Task3.Game.Obstacle
{
    using System;

    /// <summary>  
    ///  This class describes a Stone.
    /// </summary>  
    public class Stone : ObstacleAbstract
    {
        /// <summary>
        /// Initializes a new instance of the Stone class.
        /// </summary>
        /// <param name="point">point of the Stone.</param>
        public Stone(Point point) : base(point)
        {
        }

        /// <summary>
        /// Override equals coordinates 
        /// </summary>
        /// <param name="player">Current player.</param>
        public override void EqualsCoordinates(Player player)
        {
            if (this.EqualsCoordinates(player.Point))
            {
                Console.WriteLine("Turn arount it is stone");
                this.LevelChange(player);
            }
        }

        /// <summary>
        /// Override level change
        /// </summary>
        /// <param name="player">Current player.</param>
        public override void LevelChange(Player player)
        {
            if (player.Health > 1)
            {
                player.Health -= 1;
            }
            else
            {
                throw new Exception("Game over");
            }
        }

        /// <summary>
        /// Override info about object
        /// </summary>
        /// <returns>string info about object.</returns>
        public override string InfoObject()
        {
            return $"Coordinaties ({Point.X}, {Point.Y})";
        }
    }
}
