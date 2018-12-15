// <copyright file="Automate.cs" company="Epam">
//     Copyright Epam. All rights reserved 
// </copyright>

namespace Epam.Task5.ToIntOrNotToInt
{
    using System.Collections.Generic;

    /// <summary>
    ///  This class create automate
    /// </summary>
    public class Automate
    {
        /// <summary>
        /// Initializes a new instance of the Automate class.
        /// </summary>
        public Automate()
        {
            this.Alphabet = new char[] { '+', '-', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'e', 'E', '.', ',' };
            this.SetStates = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            this.StartStates = new int[] { 0 };
            this.FinishStates = new int[] { 1, 8 };

            this.Table = new Dictionary<int, List<int>>();
            this.Table.Add(this.SetStates[0], new List<int> { 2, -1, 3, 1, 1, 1, 1, 1, 1, 1, 1, 1, -1, -1, -1, -1 });
            this.Table.Add(this.SetStates[1], new List<int> { -1, -1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 9, 9, 4, 4 });
            this.Table.Add(this.SetStates[2], new List<int> { -1, -1, 3, 1, 1, 1, 1, 1, 1, 1, 1, 1, -1, -1, -1, -1 });
            this.Table.Add(this.SetStates[3], new List<int> { -1, -1, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, -1, -1, 4, 4 });
            this.Table.Add(this.SetStates[4], new List<int> { -1, -1, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, -1, -1, -1, -1 });
            this.Table.Add(this.SetStates[5], new List<int> { -1, -1, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 6, 6, -1, -1 });
            this.Table.Add(this.SetStates[6], new List<int> { 7, -1, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, -1, -1, -1, -1 });
            this.Table.Add(this.SetStates[7], new List<int> { -1, -1, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, -1, -1, -1, -1 });
            this.Table.Add(this.SetStates[8], new List<int> { -1, -1, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, -1, -1, -1, -1 });
            this.Table.Add(this.SetStates[9], new List<int> { 7, 7, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, -1, -1, -1, -1 });
        }

        /// <summary>
        /// Gets Alphabet of automate
        /// </summary>
        public char[] Alphabet { get; private set; }

        /// <summary>
        /// Gets SetStates of automate
        /// </summary>
        public int[] SetStates { get; private set; }

        /// <summary>
        /// Gets StartStates of automate
        /// </summary>
        public int[] StartStates { get; private set; }

        /// <summary>
        /// Gets FinishStates of automate
        /// </summary>
        public int[] FinishStates { get; private set; }

        /// <summary>
        /// Gets Table of automate
        /// </summary>
        public Dictionary<int, List<int>> Table { get; private set; }
    }
}
