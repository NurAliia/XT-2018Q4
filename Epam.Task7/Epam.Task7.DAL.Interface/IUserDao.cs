// <copyright file="IUserDao.cs" company="Epam">
//     Copyright Epam. All rights reserved 
// </copyright>

namespace Epam.Task7.DAL.Interface
{
    using System.Collections.Generic;
    using Epam.Task7.Entities;

    /// <summary>  
    ///  This class describes a IUserDao.
    /// </summary>  
    public interface IUserDao
    {
        /// <summary>
        /// Add new user
        /// </summary>
        /// <param name="user">New user</param>
        void Add(User user);

        /// <summary>
        /// Delete user
        /// </summary>
        /// <param name="id">user id</param>
        /// <returns>successfully or no</returns>
        bool Delete(int id);

        /// <summary>
        /// Update user
        /// </summary>
        /// <param name="user">Current user</param>
        /// <returns>successfully or no</returns>
        bool Update(User user);

        /// <summary>
        /// Get by id user
        /// </summary>
        /// <param name="id">User id</param>
        /// <returns>Current user</returns>
        User GetById(int id);

        /// <summary>
        /// Get all users
        /// </summary>
        /// <returns>collection or users</returns>
        IEnumerable<User> GetAll();

        /// <summary>
        /// Save users into file
        /// </summary>
        void Terminate();
    }
}
