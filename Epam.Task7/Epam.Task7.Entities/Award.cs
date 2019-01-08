// <copyright file="Award.cs" company="Epam">
//     Copyright Epam. All rights reserved 
// </copyright>

namespace Epam.Task7.Entities
{
    /// <summary>  
    ///  This class describes a Award.
    /// </summary>  
    public class Award
    {
        /// <summary>
        ///  Initializes a new instance of the <see cref="Award" /> class
        /// </summary>  
        /// <param name="title">name of award</param>
        public Award(string title)
        {
            this.Title = title;
        }

        /// <summary>
        ///  Initializes a new instance of the <see cref="Award" /> class
        /// </summary>  
        /// <param name="idUser">identifier of award</param>
        /// <param name="title">name of award</param>
        public Award(int idUser, string title)
        {
            this.IdUser = idUser;
            this.Title = title;
        }

        /// <summary>
        /// Gets or sets Id of the Award.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets IdUser of the Award.
        /// </summary>
        public int IdUser { get; set; }

        /// <summary>
        /// Gets or sets Title of the Award.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// New ToString()
        /// </summary>        
        /// <returns>Info about user string</returns>
        public new string ToString()
        {
            return $"{this.Title}";
        }

        /// <summary>
        /// To String into file
        /// </summary>        
        /// <returns>Full info about award string</returns>
        public string ToStringForFile()
        {
            return $"{this.Id}|{this.IdUser}|{this.Title}";
        }
    }
}
