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
        /// Create objects Figure
        /// </summary>
        public static void Main()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine(CreateFigures().ToDisplay());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        /// <summary>
        /// Create object Figure
        /// </summary>
        /// <returns>new Figure</returns>
        public static Figure CreateFigures()
        {
            Console.WriteLine($"Enter the  number of figure {Environment.NewLine}1 - Line {Environment.NewLine}2 - Circle{Environment.NewLine}3 - Rectangle{Environment.NewLine}4 - Round{Environment.NewLine}5 - Ring");
            Figure figure = null;
            if (int.TryParse(Console.ReadLine(), out int numberOfFigure) && numberOfFigure > 0 && numberOfFigure < 6)
            {
                switch (numberOfFigure)
                {
                    case 1:
                        figure = new Line(new Point(), new Point());
                        break;
                    case 2:
                        figure = new Circle(new Point(), new Point());
                        break;
                    case 3:
                        figure = new Rectangle(new Point(), new Point());
                        break;
                    case 4:
                        figure = new Round(new Point(), new Point());
                        break;
                    case 5:
                        figure = new Ring(new Point(), new Point(), new Point());
                        break;
                    default:
                        return figure;
                }

                return figure;
            }
            else
            {
                throw new Exception($" {Environment.NewLine}Please, enter a positive number from 1 to 5 {Environment.NewLine}");
            }
        }
    }
}
