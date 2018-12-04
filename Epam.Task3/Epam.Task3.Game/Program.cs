// <copyright file="Program.cs" company="Epam">
//     Copyright Epam. All rights reserved 
// </copyright>

namespace Epam.Task3.Game
{
    using System;
    using Epam.Task3.Game.Monster;
    using Epam.Task3.Game.Obstacle;

    /// <summary>  
    ///  This class performs a main function.  
    /// </summary>  
    public class Program
    {
        /// <summary>
        /// Call method create object Game
        /// </summary>
        public static void Main()
        {
            Game();
        }

        /// <summary>
        /// Create object Game
        /// </summary>
        public static void Game()
        {
            Player player = new Player(new Point(1, 1));
            Apple apple = new Apple(new Point(3, 3));
            Cherry cherry = new Cherry(new Point(4, 4));
            Wolf wolf = new Wolf(new Point(5, 5));
            Stone stone = new Stone(new Point(5, 5));
            try
            {
                for (int i = 0; i < 10; i++)
                {
                    apple.EqualsCoordinates(player);
                    cherry.EqualsCoordinates(player);
                    wolf.EqualsCoordinates(player);
                    stone.EqualsCoordinates(player);
                    if (i / 2 == 0)
                    {
                        wolf.Point.X += 1;
                    }
                    else
                    {
                        wolf.Point.Y += 1;
                    }

                    player.Point.X++;
                    player.Point.Y++;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
