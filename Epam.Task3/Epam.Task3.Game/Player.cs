// <copyright file="Player.cs" company="Epam">
//     Copyright Epam. All rights reserved 
// </copyright>

namespace Epam.Task3.Game
{
    using System;

    /// <summary>  
    ///  This class describes a Player.
    /// </summary>  
    public class Player : GameObject
    {
        /// <summary>
        /// Initializes a new instance of the Player class.
        /// </summary>
        /// <param name="point">the point of the game object</param>
        public Player(Point point) : base(point)
        {
            Console.WriteLine("Create player or taking info from file");
        }

        /// <summary>
        /// Gets or sets Health of the Game Object.
        /// </summary>
        public int Health { get; set; }

        /// <summary>
        /// Gets or sets Intelligence of the Game Object.
        /// </summary>
        public int Intelligence { get; set; }

        /// <summary>
        /// Gets or sets Agility of the Game Object.
        /// </summary>
        public int Agility { get; set; }

        /// <summary>
        /// Override method info about object
        /// </summary>
        /// <returns>string info</returns>
        public override string InfoObject()
        {
            return $"Health = {Health}, Intelligence = {Intelligence}, Agility = {Agility}";
        }
    }
}
