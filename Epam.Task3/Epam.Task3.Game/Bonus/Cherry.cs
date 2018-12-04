// <copyright file="Cherry.cs" company="Epam">
//     Copyright Epam. All rights reserved 
// </copyright>

namespace Epam.Task3.Game
{
    using System;

    /// <summary>  
    ///  This class describes a Cherry.
    /// </summary>  
    public class Cherry : BonusAbstract
    {
        /// <summary>
        /// Initializes a new instance of the Cherry class.
        /// </summary>
        /// <param name="point">point of the Cherry.</param>
        public Cherry(Point point) : base(point)
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
                Console.WriteLine("Success! Pick an cherry ");
                this.LevelChange(player);
            }
        }

        /// <summary>
        /// Override level change
        /// </summary>
        /// <param name="player">Current player.</param>
        public override void LevelChange(Player player)
        {
            player.Health += 1;
            player.Intelligence += 2;
            player.Agility += 3;
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
