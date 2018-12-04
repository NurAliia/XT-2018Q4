// <copyright file="Program.cs" company="Epam">
//     Copyright Epam. All rights reserved 
// </copyright>

namespace Epam.Task3.VectorGraphicsEditor
{
    using System;

    /// <summary>  
    ///  This class performs a main function.  
    /// </summary>  
    public class Program
    {
        /// <summary>
        /// Create object Figures
        /// </summary>
        public static void Main()
        {
            Figure line = new Line(new Point(2, 2), new Point(4, 4));
            Console.WriteLine(line.ToDisplay());
            Figure circle = new Circle(new Point(2, 4), new Point(7, 8));
            Console.WriteLine(circle.ToDisplay());
            Figure rectangle = new Rectangle(new Point(2, -6), new Point(4, 9));
            Console.WriteLine(rectangle.ToDisplay());
            Figure round = new Round(new Point(2, 2), new Point(4, 4));
            Console.WriteLine(round.ToDisplay());
            Figure ring = new Ring(new Point(2, 2), new Point(4, 4), new Point(5, 9));
            Console.WriteLine(ring.ToDisplay());
        }
    }
}
