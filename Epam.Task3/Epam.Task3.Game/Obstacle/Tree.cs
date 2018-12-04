// <copyright file="Tree.cs" company="Epam">
//     Copyright Epam. All rights reserved 
// </copyright>

namespace Epam.Task3.Game.Obstacle
{
    using System;

    /// <summary>  
    ///  This class describes a Tree.
    /// </summary>  
    public class Tree : ObstacleAbstract
    {
        /// <summary>
        /// Initializes a new instance of the Tree class.
        /// </summary>
        /// <param name="point">point of the Tree.</param>
        public Tree(Point point) : base(point)
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
                Console.WriteLine("Turn arount it is  tree");
                this.LevelChange(player);
            }
        }

        /// <summary>
        /// Override level change
        /// </summary>
        /// <param name="player">Current player.</param>
        public override void LevelChange(Player player)
        {
            if (player.Agility > 1)
            {
                player.Agility -= 1;
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
