// <copyright file="Bear.cs" company="Epam">
//     Copyright Epam. All rights reserved 
// </copyright>

namespace Epam.Task3.Game.Monster
{
    using System;

    /// <summary>  
    ///  This class describes a Bear.
    /// </summary>  
    public class Bear : MonsterAbstract
    {
        /// <summary>
        /// Initializes a new instance of the Bear class.
        /// </summary>
        /// <param name="point">point of the Bear.</param>
        public Bear(Point point) : base(point)
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
                Console.WriteLine("Fail! Met a bear");
                this.LevelChange(player);
            }
        }

        /// <summary>
        /// Override level change
        /// </summary>
        /// <param name="player">Current player.</param>
        public override void LevelChange(Player player)
        {
            if (player.Health > 3)
            {
                player.Health -= 3;
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

            if (player.Agility > 2)
            {
                player.Agility -= 2;
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
