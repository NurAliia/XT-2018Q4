// <copyright file="Apple.cs" company="Epam">
//     Copyright Epam. All rights reserved 
// </copyright>

namespace Epam.Task3.Game
{
    using System;

    /// <summary>  
    ///  This class describes a Apple.
    /// </summary>  
    public class Apple : BonusAbstract
    {
        /// <summary>
        /// Initializes a new instance of the Apple class.
        /// </summary>
        /// <param name="point">point of the Apple.</param>
        public Apple(Point point) : base(point)
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
                Console.WriteLine("Success! Pick an apple ");
                this.LevelChange(player);
            }
        }

        /// <summary>
        /// Override level change
        /// </summary>
        /// <param name="player">Current player.</param>
        public override void LevelChange(Player player)
        {
            player.Health += 3;
            player.Intelligence += 2;
            player.Agility += 1;
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
