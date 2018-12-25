// <copyright file="ObjectBackUpSystem.cs" company="Epam">
//     Copyright Epam. All rights reserved 
// </copyright>

namespace Epam.Task6.BackupSystem
{
    using System;

    /// <summary>
    /// This class create a Object Back Up System
    /// </summary>
    public class ObjectBackUpSystem
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectBackUpSystem"/> class.
        /// </summary>
        /// <param name="action">current operation</param>
        /// <param name="fullName">current path</param>
        /// <param name="oldFullName">old path of a current object</param>
        /// <param name="createDate">create date</param>
        /// <param name="id">id of a current object</param>
        public ObjectBackUpSystem(string action, string fullName, string oldFullName, DateTime createDate, long id)
        {
            this.Id = id;
            this.Action = action;
            this.FullName = fullName;
            this.OldFullName = oldFullName;
            this.CreateDate = createDate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectBackUpSystem"/> class.
        /// </summary>
        /// <param name="action">current operation</param>
        /// <param name="fullName">current path</param>
        /// <param name="createDate">create date</param>
        /// <param name="id">id of a current object</param>
        public ObjectBackUpSystem(string action, string fullName, DateTime createDate, long id)
        {
            this.Id = id;
            this.Action = action;
            this.FullName = fullName;
            this.OldFullName = fullName;
            this.CreateDate = createDate;
        }

        /// <summary>
        /// Gets or sets Id
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Gets or sets FullName
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// Gets or sets Old FullName
        /// </summary>
        public string OldFullName { get; set; }

        /// <summary>
        /// Gets or sets Create Date
        /// </summary>
        public DateTime CreateDate { get; set; }

        /// <summary>
        /// Gets or sets Action
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        /// Create new ToString method
        /// </summary>
        /// <returns>string format</returns>
        public new string ToString()
        {
            return $"{Action}|{FullName}|{OldFullName}|{CreateDate}";
        }
    }
}
