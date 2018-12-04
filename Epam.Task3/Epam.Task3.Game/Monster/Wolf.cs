// <copyright file="Wolf.cs" company="Epam">
//     Copyright Epam. All rights reserved 
// </copyright>

namespace Epam.Task3.Game.Monster
{
    using System;

    /// <summary>  
    ///  This class describes a Wolf.
    /// </summary>  
    public class Wolf : MonsterAbstract
    {
        /// <summary>
        /// Initializes a new instance of the Wolf class.
        /// </summary>
        /// <param name="point">point of the Wolf.</param>
        public Wolf(Point point) : base(point)
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
                Console.WriteLine("Fail! Met a wolf");
                this.LevelChange(player);
            }
        }

        /// <summary>
        /// Override level change
        /// </summary>
        /// <param name="player">Current player.</param>
        public override void LevelChange(Player player)
        {
            if (player.Health > 2)
            {
                player.Health -= 2;
            }
            else
            {
                throw new Exception("Game over");
            }

            if (player.Intelligence > 1)
            {
                player.Intelligence -= 1;
            }
            else
            {
                throw new Exception("Game over");
            }

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
