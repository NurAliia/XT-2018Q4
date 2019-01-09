// <copyright file="IAwardDao.cs" company="Epam">
//     Copyright Epam. All rights reserved 
// </copyright>

namespace Epam.Task7.DAL.Interface
{
    using System.Collections.Generic;
    using Epam.Task7.Entities;

    /// <summary>  
    ///  This class describes a IAwardDao.
    /// </summary>  
    public interface IAwardDao
    {
        /// <summary>
        /// Add new award
        /// </summary>
        /// <param name="award">new award</param>
        void Add(Award award);

        /// <summary>
        /// Update award
        /// </summary>
        /// <param name="award">update award</param>
        /// <returns>successfully or no</returns>
        bool Update(Award award);

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
        /// Save awards into file
        /// </summary>
        void Terminate();
    }
}
