// <copyright file="IAwardLogic.cs" company="Epam">
//     Copyright Epam. All rights reserved 
// </copyright>

namespace Epam.Task7.BLL.Interface
{
    using System.Collections.Generic;
    using Epam.Task7.Entities;

    /// <summary>  
    ///  This class describes a IAwardLogic.
    /// </summary>  
    public interface IAwardLogic
    {
        /// <summary>
        /// Add new award
        /// </summary>
        /// <param name="idUser">Current user</param>
        /// <param name="title">new award</param>
        void Add(int idUser, string title);

        /// <summary>
        /// Update award
        /// </summary>
        /// <param name="id">id of current award</param>
        /// <param name="title">new title of award</param>
        /// <returns>successfully or no</returns>
        bool Update(int id, string title);

        /// <summary>
        /// Delete award
        /// </summary>
        /// <param name="id">award id</param>
        /// <returns>successfully or no</returns>
        bool Delete(int id);

        /// <summary>
        /// Delete by user award
        /// </summary>
        /// <param name="idUser">user id</param>
        /// <returns>successfully or no</returns>
        bool DeleteByUser(int idUser);

        /// <summary>
        /// Get by id award
        /// </summary>
        /// <param name="id">award id</param>
        /// <returns>current award</returns>
        Award GetById(int id);

        /// <summary>
        /// Get all awards
        /// </summary>
        /// <returns>collection of awards</returns>
        IEnumerable<Award> GetAll();

        /// <summary>
        /// Get all by user id award
        /// </summary>
        /// <param name="idUser">user id</param>
        /// <returns>collection of awards by user</returns>
        IEnumerable<Award> GetAllByUserId(int idUser);

        /// <summary>
        /// Terminate work with awards into file
        /// </summary>
        void Terminate();
    }
}
